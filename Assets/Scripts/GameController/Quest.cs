using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Quest {

    private int score;
    private int questID; //finding quest 1xxxx, helping quest 2xxxx
    private string questName;
    private string questDescription; 
    private string questStatus; //incomplete, in progress, completed
    private List<int> nextQuestID;
    private Dictionary<int,bool> conversationMapID;
    public Quest(int questID, string questName, string questDescription, string questStatus, int score)
    {
        this.score = score;
        this.questID = questID;
        this.questName = questName;
        this.questDescription = questDescription;
        this.questStatus = questStatus;
        nextQuestID = new List<int>();
        conversationMapID = new Dictionary<int, bool>();
    }

    public int Score
    {
        set { this.score = Score; }
        get { return this.score; }
    }

    public int QuestID
    {
        set {  this.questID = QuestID; }
        get {  return this.questID; }
    }

    public string QuestName
    {
        set {  this.questName = QuestName; }
        get {  return this.questName; }
    }

    public string QuestDescription
    {
        set {  this.questDescription = QuestDescription; }
        get { return this.questDescription;  }
    }

    public void setQuestStatus(string questStatus)
    {
        this.questStatus = questStatus;  
    }

    public string getQuestStatus()
    {
        return this.questStatus;
    }


    public void addnextQuestID(int questID)
    {
        nextQuestID.Add(questID);
    }
    public int[] getNextQuestID()
    {
        return nextQuestID.ToArray();
    }
    public void AddConversationMap(int mapID,bool isFinish)
    {
        conversationMapID.Add(mapID,isFinish);
    }
    public bool haveConversationMap(int mapID)
    {
        bool result = false;
        if (conversationMapID.ContainsKey(mapID))
        {
            result = true;
        }
        return result;
    }
    public void setConversationFinish(int mapID, bool isFinish)
    {
        if (conversationMapID.ContainsKey(mapID))
        {
            conversationMapID[mapID] = isFinish;
        }
    }
    public bool getConversationFinish(int mapID)
    {
        bool result = false;
        if (conversationMapID.ContainsKey(mapID)){
            result = conversationMapID[mapID];
        }
        else
        {
            result = false;
        }
        return result;
    }
}
