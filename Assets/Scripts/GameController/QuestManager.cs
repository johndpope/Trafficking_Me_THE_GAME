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
        FindingQuest temp = new FindingQuest(0, "Help Friend", "Go and rescue your friend", "incomplete", 100);
        temp.addItemQuest(new ItemQuest(1, "box", false, Spawn.one));
        temp.addItemQuest(new ItemQuest(2, "box", false, Spawn.one));
        temp.addItemQuest(new ItemQuest(3, "box", false, Spawn.one));
        temp.addItemQuest(new ItemQuest(4, "box", false, Spawn.one));
        temp.addMap(new int[]{5,11});
        temp.randomItems();
        temp.AddConversationMap(2, false);
        questList.Add(0, temp);

        MapQuest temp2 = new MapQuest(1, "Find the way out", "Find the main door of the building", "incomplete", 30, 69, 2);
        temp2.setDestination(33);
        questList.Add(1, temp2);
        
        Quest temp3 = new Quest(2, "Contact authority", "Find the way to contact authority for help", "incomplete", 100);
        temp3.AddConversationMap(5, false);
        questList.Add(2, temp3);
    }

    public void setQuestStatus(Quest quest, string status)
    {
        int key = quest.QuestID;
        questList[key].QuestStatus = status;
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
