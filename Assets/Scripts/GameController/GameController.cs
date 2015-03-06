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
    CharacterEmotion player;

    public string currentMap;
    public string previousMap;

    private float enemyDelayTime = 1.5f; 
    private bool enemyInActive;
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterEmotion>();
        questManager = new QuestManager();
        thingManager = new ThingManager();
        currentQuest = questManager.getCurrentQuest(0); //let default quest is mission 0 
        currentMap = Application.loadedLevelName;
        
	}

	// Update is called once per frame
	void Update () {
        //Debug.Log(currentQuest.QuestID);

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
        
	}

    void UpdateQuestStatus()
    {
        if (currentQuest.QuestStatus == "incomplete")
        {
            currentQuest.QuestStatus = "in progress";
            questManager.setQuestStatus(currentQuest, currentQuest.QuestStatus);
        }
        else if(currentQuest.QuestStatus == "completed"){
            //currentQuest.QuestStatus = "completed";
            questManager.setQuestStatus(currentQuest, currentQuest.QuestStatus);
        }
    }
    public bool IsItemInQuest(int MapID, Spawn position)
    {
        bool haveItem = false;
        if (currentQuest != null)
        {
            if (currentQuest.GetType() == typeof(HelpingQuest))
            {

            }
            else if (currentQuest.GetType() == typeof(FindingQuest))
            {
                FindingQuest temp = (FindingQuest)currentQuest;
                haveItem = temp.HaveItem(MapID, position);
                
            }
            else if (currentQuest.GetType() == typeof(BossQuest))
            {

            }
            else if (currentQuest.GetType() == typeof(MapQuest)){
                
                
            }
        }
        return haveItem;
    }
    public bool isAlreadyHaveItem(int MapID, Spawn position)
    {
        bool haveItem = false;
        if (currentQuest != null)
        {
            if (currentQuest.GetType() == typeof(HelpingQuest))
            {

            }
            else if (currentQuest.GetType() == typeof(FindingQuest))
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

        return arrived;
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
        if (player.getTrustiness() <= 0)
        {
            if (persentageVictim + persentageAddional >= 100)
            {
                tempPersentage = 100;
            }
            else
            {
                tempPersentage = persentageAddional + persentageVictim;
            }
        }
        else
        {
            tempPersentage = persentageVictim;
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
                GameObject victim = (GameObject)Instantiate(Resources.Load("Prefabs/Victim"), allSpawnPoint[0].transform.position + new Vector3(0,1,0), Quaternion.Euler(0, 0, 0));
                victim.GetComponent<VictimScript>().ID = allSpawnPoint[0].GetComponent<SpawnScript>().ID;
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
                GameObject enemy = (GameObject)Instantiate(Resources.Load("Prefabs/Enemy"), allSpawnPoint[0].transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
                enemy.GetComponent<EnemyScript>().spawnScreen = Application.loadedLevelName;
                enemy.GetComponent<EnemyScript>().ID = allSpawnPoint[0].GetComponent<SpawnScript>().ID;
            }

        }
    }
}
