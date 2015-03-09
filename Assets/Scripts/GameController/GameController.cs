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
    public float persentageVictim;
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
    
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterEmotion>();
        questManager = new QuestManager();
        thingManager = new ThingManager();
        currentQuest = questManager.getCurrentQuest(0); //let default quest is mission 0 
        currentMap = Application.loadedLevelName;

        //change default quest from incomplete to inprogress
        UpdateQuestStatus();



	}

	// Update is called once per frame
	void Update () {
        //Debug.Log(currentQuest.QuestID);
        
        if (currentQuest.getQuestStatus() == "incomplete")
        {
            UpdateQuestStatus();
            addScore = true;
        }

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

        if(enemyDoorEvent){
            RandomSummonEvent();
            enemyDoorEvent = false;
        }

        if(timeImmuneToCorpse > 0){
            timeImmuneToCorpse -= Time.deltaTime;
            Debug.Log(timeImmuneToCorpse);
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
            else if (currentQuest.GetType() == typeof(BossQuest))
            {

            }
            else if (currentQuest.GetType() == typeof(MapQuest))
            {


            }
        }
            
        return haveItem;
    }
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
            else if (currentQuest.GetType() == typeof(BossQuest))
            {

            }
            else if (currentQuest.GetType() == typeof(MapQuest))
            {


            }
        }
        return haveItem;
    }

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

    public bool IsBossKilled()
    {
        bool result = false;

        if(currentQuest.GetType() == typeof(BossQuest)){
            BossQuest temp = (BossQuest)currentQuest;
            result = temp.IsBossKilled();
        }

        return result;
    }

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

    public void Timealert()
    {
        if (alertTime > 0)
        {
            alertTime -= Time.deltaTime;
        }
        else
        {
            stopEnemy();
            isAlert = false;
            
        }
    }
    public void stopEnemy()
    {

        GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //Debug.Log("sum of enemy"+enemy.Length);
        for (int i = 0; i < enemy.Length; i++)
        {
            enemy[i].SendMessage("stopEnemyfindPlayer");
        }
    }
    public void SetAlert(bool n)
    {
        alertTime = timeAlertEnd;
        isAlert = n;
    }
    public bool haveConversation(int mapID){
        bool temp = false;
        
        if (currentQuest != null)
        {
            temp = currentQuest.haveConversationMap(mapID);
            
        }
        //Debug.Log(temp);
        return temp;
    }
    public bool HavetoSummonEnemy()
    {
        bool result = false;
        float tempPersentage = 0;
        if (player.getTrustiness() <= 0)
        {
            if (persentageEnemy + persentageAddional >= 100)
            {
                tempPersentage = 100;
            }
            else
            {
                tempPersentage = persentageAddional + persentageEnemy;
            }
        }
        else
        {
            tempPersentage = persentageEnemy;
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

    public bool HaveToSummonVictim()
    {

        bool result = false;
        float tempPersentage = 0;
        
        tempPersentage = persentageVictim;
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

        RandomSummonVictim();
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
                enemy[i].renderer.enabled = true;
                enemy[i].GetComponent<EnemyScript>().inActive = false;
            }
            
            enemyInActive = false;
        }
    }

    public void RandomSummonVictim()
    {
        GameObject[] allSpawnPoint = GameObject.FindGameObjectsWithTag("SpawnPointVictim");

        for (int i = 0; i < allSpawnPoint.Length; i++)
        {
            bool temp = HaveToSummonVictim();
            if (temp)
            {
                GameObject victim = (GameObject)Instantiate(Resources.Load("Prefabs/Victim"), allSpawnPoint[i].transform.position + new Vector3(0,1,0), Quaternion.Euler(0, 0, 0));
                victim.GetComponent<VictimScript>().ID = allSpawnPoint[i].GetComponent<SpawnScript>().ID;
            }
        }
    }

    public void RandomSummonEnemy()
    {
        GameObject[] allSpawnPoint = GameObject.FindGameObjectsWithTag("SpawnPointEnemy");
        
        for (int i = 0; i < allSpawnPoint.Length; i++)
        {
            bool temp = HavetoSummonEnemy();
            if (temp)
            {
                GameObject enemy = (GameObject)Instantiate(Resources.Load("Prefabs/Enemy"), allSpawnPoint[i].transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
                enemy.GetComponent<EnemyScript>().spawnScreen = Application.loadedLevelName;
                enemy.GetComponent<EnemyScript>().ID = allSpawnPoint[i].GetComponent<SpawnScript>().ID;
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
