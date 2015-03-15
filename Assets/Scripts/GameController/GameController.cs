using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public float gameTime; //time spend in this game
    private Quest currentQuest;
    private QuestManager questManager;
    private ThingManager thingManager;
    public bool isAlert;
    public float timeAlertEnd = 5;
    private float alertTime;
    public EventHandling eventHandling;
    public float persentageEnemy;
    //public float persentageVictim;
    public float persentageAddional;
    public float persentageCorpse;
    CharacterEmotion player;

    public string currentMap;
    public string previousMap;

    private float enemyDelayTime = 1.5f; 
    private bool enemyInActive;

    private int finalScore;
    private bool addScore = true; //prevent duplicate add score
    //private bool randomEventHappen = true; //prevent duplicate spawn enemy via door
    private bool enemyDoorEvent;
    private float timeImmuneToCorpse = 0;
    public bool immuneCorpse = false;
    public int maxEnemy;
    VictimList victimList;
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterEmotion>();
        questManager = new QuestManager();
        thingManager = new ThingManager();
        currentQuest = questManager.getCurrentQuest(0); //let default quest is mission 0 
        currentMap = Application.loadedLevelName;

        //change default quest from incomplete to inprogress
        UpdateQuestStatus();

        //total victim in game
        victimList = new VictimList();
        victimList.addVictim(new Victim(1, false, false, SpawnV.one));
        victimList.addVictim(new Victim(2, false, false, SpawnV.one));
        victimList.addVictim(new Victim(3, false, false, SpawnV.one));
        victimList.addVictim(new Victim(4, false, false, SpawnV.one));
        victimList.addVictim(new Victim(5, false, false, SpawnV.one));
        victimList.addVictim(new Victim(6, false, false, SpawnV.one));
        victimList.addVictim(new Victim(7, false, false, SpawnV.one));
        victimList.addMap(new int[] { 3, 14, 15, 17, 19, 21, 22, 26, 32 }, new int[] { 1, 1, 1, 1, 1, 1, 2, 1, 1 });
        victimList.randomVictim();

	}

	// Update is called once per frame
	void Update () {
        //Debug.Log(currentQuest.QuestID);
        
        if (currentQuest.getQuestStatus() == "incomplete")
        {
            UpdateQuestStatus();
            addScore = true;
        }

        //when enemy hiding in the locker, renderer is false
        if (player.renderer.enabled == false)
        {
            player.SendMessage("IsHiding", true);
        }
        else
        {
            player.SendMessage("IsHiding", false);
        }

        gameTime += Time.deltaTime;
        if (isAlert)
        {
            Timealert();
            //Debug.Log("alert!! " + alertTime);
        }

        //delay time before enemy appear on the door
        if (enemyInActive)
        {
            EnemyDoorDelay();
        }

        //enemy knock the door event
        if(enemyDoorEvent){
            RandomSummonEvent();
            enemyDoorEvent = false;
        }

        //when player found corpse, immune to corpse for limited of time (not stun)
        if(timeImmuneToCorpse > 0){
            timeImmuneToCorpse -= Time.deltaTime;
            //Debug.Log(timeImmuneToCorpse);
        }
        else
        {
            immuneCorpse = false;
        }
        
	}

    public Quest getCurrentQuest()
    {
        return currentQuest;
    }

    //set current quest status
    void UpdateQuestStatus()
        
    {
        if (currentQuest.getQuestStatus() == "incomplete")
        {
            questManager.setQuestStatus(currentQuest, "inprogress");
        }
        else if (currentQuest.getQuestStatus() == "inprogress")
        {
            questManager.setQuestStatus(currentQuest, "completed");
        }
    }

    //check to see that is there an item in the current quest and map, so that the game can spawn that item quest
    public bool IsItemInQuest(int MapID, Spawn position, out string item)
    {
        bool haveItem = false;
        item = "";
        if (currentQuest != null)
        {
            
            if (currentQuest.GetType() == typeof(FindingQuest))
            {
                FindingQuest temp = (FindingQuest)currentQuest;
                haveItem = temp.HaveItem(MapID, position, out item);

            }
            
        }
            
        return haveItem;
    }

    //check to see that is player already collect the quest item in this quest and map or not
    public bool isAlreadyHaveItem(int MapID, Spawn position)
    {
        bool haveItem = false;
        if (currentQuest != null)
        {
            
            if (currentQuest.GetType() == typeof(FindingQuest))
            {
                FindingQuest temp = (FindingQuest)currentQuest;
                haveItem = temp.IsCollect(MapID,position);
            }
            
        }
        return haveItem;
    }

    //set player collect this quest item, so the next time player coming the quest item will not spawn
    public void SetHaveItem(int key, Spawn position)
    {
        if (currentQuest != null && currentQuest.GetType() == typeof(FindingQuest))
        {
            FindingQuest temp = (FindingQuest)currentQuest;
            temp.setIsCollect(key,position);
            currentQuest = temp;

            //if all item collected, change to destination quest
            if (temp.allItemCollected())
            {
                //convert finding quest to map quest
                currentQuest = new MapQuest(currentQuest.QuestID, currentQuest.QuestName, currentQuest.QuestDescription,
                    currentQuest.getQuestStatus(), currentQuest.Score, 0, temp.FinalDestination);

                //also update dictionary in quest manager
                questManager.questList[currentQuest.QuestID] = currentQuest;
            }
        }
    }

    //check to see that is player arrive at quest destination or not
    public bool IsArrive(int key)
    {

        bool arrived = false;

        if (currentQuest.GetType() == typeof(MapQuest))
        {
            MapQuest temp = (MapQuest)currentQuest;
            arrived = temp.IsInDestination(key);
        }
        else if (currentQuest.GetType() == typeof(BossQuest))
        {
            BossQuest temp = (BossQuest)currentQuest;
            arrived = temp.IsInDestination(key);
        }

        return arrived;
    }

    //check to see boss status, killed or not killed
    public bool IsBossKilled()
    {
        bool result = false;

        if(currentQuest.GetType() == typeof(BossQuest)){
            BossQuest temp = (BossQuest)currentQuest;
            result = temp.IsBossKilled();
        }

        return result;
    }

    //change boss status for boss quest
    public void UpdateBossStatus()
    {
        if (currentQuest.GetType() == typeof(BossQuest))
        {
            BossQuest temp = (BossQuest)currentQuest;
            temp.SetBossKilled();

            UpdateQuestStatus();

            if (currentQuest.getQuestStatus() == "completed")
            {
                finalScore += currentQuest.Score;
            }

        }
    }

    //set time enemy alert
    public void Timealert()
    {
        if (alertTime > 0)
        {
            alertTime -= Time.deltaTime;
        }
        else //if time alert less than zero, stop enemy
        {
            stopEnemy();
            isAlert = false;
            
        }
    }

    //method to send message to enemy to stop finding player
    public void stopEnemy()
    {

        GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] dog = GameObject.FindGameObjectsWithTag("Dog");
        //Debug.Log("sum of enemy"+enemy.Length);
        for (int i = 0; i < enemy.Length; i++)
        {
            enemy[i].SendMessage("stopEnemyfindPlayer");
        }

        for (int i = 0; i < dog.Length; i++)
        {
            dog[i].SendMessage("StopDogFindPlayer");
        }
    }
    //received the value from enemy script when enemy detect player to set enemy alert time in game controller
    public void SetAlert(bool n)
    {
        alertTime = timeAlertEnd;
        isAlert = n;
    }

    //check this map have conversation/visual novel or not
    public bool haveConversation(int mapID){
        bool temp = false;
        
        if (currentQuest != null)
        {
            temp = currentQuest.haveConversationMap(mapID);
            
        }
        //Debug.Log(temp);
        return temp;
    }

    //return that this map going to summon enemy, from the random value
    public bool HavetoSummonEnemy(int persentage)
    {
        bool result = false;
        float tempPersentage = 0;
        if (player.getTrustiness() <= 0) //when trustiness stat depleted, chance to find enemy increase
        {
            if (persentage + persentageAddional >= 100)
            {
                tempPersentage = 100;
            }
            else
            {
                tempPersentage = persentageAddional + persentage;
            }
        }
        else
        {
            tempPersentage = persentage;
        }
        int random = Random.Range(0, 100);
        //Debug.Log(random+" "+Random.seed);
        if (random < tempPersentage)
        {
            result = true;
        }
        else
        {
            result = false;
        }        
            return result;
    }

    //check that is there victim in this map or not
    public bool HaveVictimInMap(int mapID, SpawnV spawn)
    {
        bool haveVictim = victimList.haveVictim(mapID, spawn);

        return haveVictim;
    }

    //check that is player already help victim in this map or not
    public bool IsAlreadyHelpVictim(int mapID, SpawnV spawn)
    {
        bool alreadyHelp = victimList.IsHelp(mapID, spawn);
        return alreadyHelp;
    }

    //set help status of victim in this map, so the next time come to this map victim won't appear
    public void SetHelpVictim(int key, SpawnV position)
    {
        victimList.setIsHelp(key, position);
    }

    //when enemy caught victim, set help status to fail and return the victim back to original position for help again
    public void SetHelpVictimFail(int key, int victimID)
    {
        victimList.setHelpFail(key, victimID);
    }

    //when escort victim to toilet successful, set escort status 
    public void SetEscortVictim(int key, int victimID)
    {
        victimList.setIsEscort(key, victimID);
    }

    //return the victim id that player help
    public int GetVictimID(int key, SpawnV position)
    {
        return victimList.getVictimID(key, position);
    }

    public bool HaveToSummonBraveryItem()
    {
        bool result = false;
        float tempPersentage = 0;

        tempPersentage = persentageCorpse;
        int random = Random.Range(0, 100);
        if (random < tempPersentage)
        {
            result = true;
        }
        else
        {
            result = false;
        }
        return result;
    }

    public void setHaveConversation(int mapID,bool isFinish)
    {
        if (currentQuest != null)
        {
            if(haveConversation(mapID)){
                currentQuest.setConversationFinish(mapID, isFinish);
            }
        }
    }
    public bool getHaveConversation(int mapID)
    {
        bool result = false;
        if (currentQuest != null)
        {
            if (haveConversation(mapID))
            {
                result = currentQuest.getConversationFinish(mapID);
            }
        }
        return result;
    }

    public void changeCurrentMission(int questID)
    {
        if (questManager.getCurrentQuest(questID) != null)
        {
            currentQuest = questManager.getCurrentQuest(questID);
        }
    }


    void OnLevelWasLoaded(int level)
    {
        previousMap = currentMap;
        currentMap = Application.loadedLevelName;

        RandomSummonEnemy();

        checkMapQuestArrive();
        
    }

    void checkMapQuestArrive()
    {
        if (currentQuest != null && currentQuest.GetType() == typeof(MapQuest))
        {
            
            if (IsArrive(Application.loadedLevel))
            {
                Debug.Log("map quest complete");
                UpdateQuestStatus();
                //when complete the quest, add the score to the current score
                if (currentQuest.getQuestStatus() == "completed" && addScore == true)
                {
                    finalScore += currentQuest.Score;
                    addScore = false;
                }
            }
        }
    }

    public void EnemyNewScreen(bool n)
    {
        enemyDelayTime = 1.5f;
        enemyInActive = true;
        
    }

    public void EnemyDoorDelay()
    {
        
        if (enemyDelayTime > 0)
        {
            enemyDelayTime -= Time.deltaTime;
        }
        else
        {
            GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i].GetComponent<EnemyScript>().inActive = false;
                enemy[i].renderer.enabled = true;
                if(player.renderer.enabled == false){
                    enemy[i].GetComponent<EnemyScript>().isAttackEnemy = false;
                }
            }

            GameObject[] dog = GameObject.FindGameObjectsWithTag("Dog");
            for (int i = 0; i < dog.Length; i++)
            {

                dog[i].GetComponent<DogScript>().inActive = false;
                dog[i].renderer.enabled = true;
                if (player.renderer.enabled == false)
                {
                    dog[i].GetComponent<DogScript>().isAttackEnemy = false;
                }
            }
            
            enemyInActive = false;
        }
    }

    public void RandomSummonEnemy()
    {
        GameObject[] allSpawnPoint = GameObject.FindGameObjectsWithTag("SpawnPointEnemy");
        GameObject[] allEnemy = GameObject.FindGameObjectsWithTag("Enemy");
        int count = allEnemy.Length;
        for (int i = 0; i < allSpawnPoint.Length; i++)
        {
            int persentage = allSpawnPoint[i].GetComponent<SpawnScript>().spawnPersentage;
            string tempID = allSpawnPoint[i].GetComponent<SpawnScript>().ID;
            bool haveSameID = false;
            
            for (int j = 0; j < allEnemy.Length; j++)
            {
                EnemyScript enemies =  allEnemy[j].GetComponent<EnemyScript>();
                if (enemies.ID == tempID)
                {
                    haveSameID = true;
                    break;
                }
            }
            //Debug.Log("enemy length " +allEnemy.Length);
            if (count > maxEnemy) //***dont forget to fix 
            {
                
                haveSameID = true;
            }
            if (!haveSameID)
            {
                
                bool temp = HavetoSummonEnemy(persentage);
                if (temp && count < maxEnemy)
                {
                    GameObject enemy = (GameObject)Instantiate(Resources.Load("Prefabs/Enemy"), allSpawnPoint[i].transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
                    enemy.GetComponent<EnemyScript>().spawnScreen = Application.loadedLevelName;
                    enemy.GetComponent<EnemyScript>().ID = allSpawnPoint[i].GetComponent<SpawnScript>().ID;
                    //enemy.GetComponent<EnemyScript>().wallLeft = allSpawnPoint[i].GetComponent<SpawnScript>().wallLeft;
                    //enemy.GetComponent<EnemyScript>().wallRight = allSpawnPoint[i].GetComponent<SpawnScript>().wallRight;
                    count++;
                }
            }
            

        }
    }


    public void SetEventOccur(bool n)
    {
        enemyDoorEvent = n;
    }

    //summon enemy via door
    public void RandomSummonEvent()
    {

        StartCoroutine(DoorSoundEvent(3.0F)); 
        StartCoroutine(DoorSoundEvent(4.0F));
        StartCoroutine(WaitBeforeEventOccur(5.0F)); //enemy appear after 10 second

        
    }

    public void FoundCorpse(bool n)
    {
        timeImmuneToCorpse = 30;
        immuneCorpse = n;
    }
    
    IEnumerator WaitBeforeEventOccur(float time)
    {

        yield return new WaitForSeconds(time);

        GameObject[] allDoor = GameObject.FindGameObjectsWithTag("Door");

        for (int i = 0; i < allDoor.Length; i++)
        {
            if (allDoor[i].GetComponent<DoorEnter>().isTriggerEvent == true)
            {

                GameObject enemy = (GameObject)Instantiate(Resources.Load("Prefabs/Enemy"), allDoor[i].transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
                enemy.GetComponent<EnemyScript>().spawnScreen = Application.loadedLevelName;
                enemy.GetComponent<EnemyScript>().ID = "0A";
                allDoor[i].GetComponent<DoorEnter>().isTriggerEvent = false;
                allDoor[i].GetComponent<DoorEnter>().isLock = false;
            }
        }

        Debug.Log("EventOccur!!!");
        
    }

    IEnumerator DoorSoundEvent(float time)
    {
        yield return new WaitForSeconds(time);

        Debug.Log("knock knock");
        
    }


}
