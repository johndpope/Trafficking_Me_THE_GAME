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

        //A00 - prologue
        MapQuest temp = new MapQuest(0, "Find the way out", "Avoid detection and escape from this place", "incomplete", 100, 0, 2);
        temp.AddConversationMap(1, false);
        temp.AddConversationMap(3, false);
        questList.Add(0, temp);

        //A01
        temp = new MapQuest(1, "Help your friends", "Investigate the cell room and help your friend", "incomplete", 200, 3, 21);
        temp.AddConversationMap(22, false);
        questList.Add(1, temp);

        //A02
        temp = new MapQuest(2, "Find the useful information", "Go to the document room and find the useful information for escape",
            "incomplete" ,100, 3, 12);
        temp.AddConversationMap(13, false);
        questList.Add(2, temp);

        //B01
        temp = new MapQuest(3, "Contact Authority for help", "Sneak to the control room and find a way to contact authority",
            "incomplete", 300, 0, 10);
        temp.AddConversationMap(11, false);
        questList.Add(3, temp);

        //B02_1
        temp = new MapQuest(4, "Find Amata", "Go to the destination point to see Amata", "incomplete", 100, 21, 17);
        temp.AddConversationMap(18, false);
        questList.Add(4, temp);

        //B02_2
        temp = new MapQuest(5, "Searching for Amata", "Locate and find Amata", "incomplete", 100, 17, 13);
        temp.AddConversationMap(13, false);
        questList.Add(5, temp);

        //B03
        FindingQuest temp2 = new FindingQuest(6, "Sabotage trafficker shipment", "Find the item for destroy the trafficker shipment",
            "incomplete", 400, 22);
        temp2.addItemQuest(new ItemQuest(1, "wood", false, Spawn.one));
        temp2.addItemQuest(new ItemQuest(2, "wood", false, Spawn.one));
        temp2.addItemQuest(new ItemQuest(3, "paper", false, Spawn.one));
        temp2.addItemQuest(new ItemQuest(4, "paper", false, Spawn.one));
        temp2.addItemQuest(new ItemQuest(5, "match", false, Spawn.one));
        temp2.addMap(new int[] { 5, 7, 9, 20, 24 });
        temp2.randomItems();
        temp2.AddConversationMap(23, false);
        questList.Add(6, temp2);

        //C01
        temp = new MapQuest(7, "Find the exit door", "Find the exit door to escape from this place",
            "incomplete", 200, 0, 35);
        temp.AddConversationMap(38, false);
        questList.Add(7, temp);

        //C02
        BossQuest temp3 = new BossQuest(8, "Fight the boss", "Go to the boss room and beat him", "incomplete", 500, 30, false);
        temp3.AddConversationMap(30, false);
        questList.Add(8, temp3);

        //C03
        temp = new MapQuest(9, "Find hiding place", "Find the room for hiding until authority arrived", "incomplete", 200, 10, 26);
        temp.AddConversationMap(27, false);
        questList.Add(9, temp);

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
