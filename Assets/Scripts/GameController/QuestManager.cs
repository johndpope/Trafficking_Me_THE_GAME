using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestManager
{

    public Dictionary<int, Quest> questList;
    public QuestManager()
    {
        questList = new Dictionary<int, Quest>();
        Initial();
    }

    public void Initial()
    {
        /*FindingQuest temp = new FindingQuest(0, "Help Friend", "Go and rescue your friend", "incomplete", 100, 33);
        temp.addItemQuest(new ItemQuest(1, "box", false, Spawn.one));
        temp.addItemQuest(new ItemQuest(2, "box", false, Spawn.one));
        temp.addItemQuest(new ItemQuest(3, "box", false, Spawn.one));
        temp.addItemQuest(new ItemQuest(4, "box", false, Spawn.one));
        temp.addMap(new int[]{5,11});
        temp.randomItems();
        temp.AddConversationMap(2, false);
        questList.Add(0, temp);

        questList.Add(1, new MapQuest(1, "Find the way out", "Find the main door of the building", "incomplete", 30, 0, 33));
        
        Quest temp2 = new Quest(2, "Contact authority", "Find the way to contact authority for help", "incomplete", 100);
        temp2.AddConversationMap(5, false);
        questList.Add(2, temp2);

        BossQuest temp3 = new BossQuest(3, "Fight the boss", "Go to the boss room and beat him", "incomplete", 200, 30, false);
        temp3.AddConversationMap(30, false);
        questList.Add(3, temp3);*/

        MapQuest temp = new MapQuest(0, "Find the way out", "Avoid detection and escape from this place", "incomplete", 100, 0, 2);
        temp.AddConversationMap(1, false);
        temp.AddConversationMap(3, false);
        questList.Add(0, temp);

        MapQuest temp2 = new MapQuest(1, "Help your friends", "Investigate the cell room and help your friend", "incomplete", 200, 3, 21);
        temp2.AddConversationMap(22, false);
        questList.Add(1, temp2);

        MapQuest temp3 = new MapQuest(2, "Find the useful information", "Go to the document room and find the useful information for escape",
            "incomplete" ,100, 3, 12);
        temp3.AddConversationMap(13, false);
        questList.Add(2, temp3);

        questList.Add(3, new Quest(3, "Quest name", "Quest description", "incomplete", 0));
        questList.Add(4, new Quest(4, "Quest name", "Quest description", "incomplete", 0));
        questList.Add(5, new Quest(5, "Quest name", "Quest description", "incomplete", 0));
    }

    public void setQuestStatus(Quest quest, string status)
    {
        int key = quest.QuestID;
        questList[key].setQuestStatus(status);
    }

    public Quest getCurrentQuest(int key)
    {
        Quest result;
        if (questList.ContainsKey(key))
        {
            result = questList[key];
        }
        else
        {
            result = null;
        }
        return questList[key];
    }



}
