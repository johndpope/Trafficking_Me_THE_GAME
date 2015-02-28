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
    public float persentageAddional;
    CharacterEmotion player;

    public string currentMap;
    public string previousMap;
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterEmotion>();
        questManager = new QuestManager();
        thingManager = new ThingManager();
        currentQuest = questManager.getCurrentQuest(0); //let default quest is mission 1 

        currentMap = Application.loadedLevelName;
	}
	
	// Update is called once per frame
	void Update () {

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
            Timealtert();
            //Debug.Log("alert!! " + alertTime);
        }
        else if (player.renderer.enabled)
        {
            //GameObject.FindGameObjectWithTag("Enemy").SendMessage("UnAlert", true);
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
    public bool GetItemInQuest(int key)
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
                haveItem = temp.HaveItem(key);
            }
            else if (currentQuest.GetType() == typeof(BossQuest))
            {

            }
            else if (currentQuest.GetType() == typeof(MapQuest)){
                
                
            }
        }
        return haveItem;
    }
    public bool isAlreadyHaveItem(int key)
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
                haveItem = temp.IsCollect(key);
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
    public void Timealtert()
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

        GameObject[] enemy = GameObject.FindGameObjectsWithTag("enemy");
        Debug.Log("sum of enemy"+enemy.Length);
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
        Debug.Log(random+" "+Random.seed);
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
    }
}
