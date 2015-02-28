using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindingQuest : Quest {


    private List<List<int>> objectiveLocation; //map that contain this quest
    public FindingQuest(int questID, string questName, string questDescription, string questStatus, int score) : base(questID, questName, questDescription, questStatus, score) 
    {
        objectiveLocation = new List<List<int>>();
    }
    // 1= true;
    //2 = false;
    public void addObjectiveLocation(int itemID, int mapID, int isCollect)
    {
        /*
         * {itemID,mapID,isCollect},
         * {itemID,mapID,isCollect}
         */
        List<int> temp = new List<int>();
        temp.Add(itemID);
        temp.Add(mapID);
        temp.Add(isCollect);
        objectiveLocation.Add(temp);
    }
    //keyID = mapID
    public void getItemLocation(int keyID, out int itemID, out int mapID)
    {
        int tempItem =0;
        int tempMap =0;
        for (int i = 0; i < objectiveLocation.Count; i++)
        {
            if (objectiveLocation[i][1] == keyID)
            {
                tempItem = objectiveLocation[i][0];
                tempMap = objectiveLocation[i][1];
                break;
            }
        }
        itemID = tempItem;
        mapID = tempMap;
    }

    public bool HaveItem(int keyID)
    {
        bool result = false;

        for (int i = 0; i < objectiveLocation.Count; i++)
        {
            if (objectiveLocation[i][0] == keyID)
            {
                result = true;
                break;
            }
        }

            return result;
    }
    public bool IsCollect(int keyID)
    {
        bool result = false;
        for (int i = 0; i < objectiveLocation.Count; i++)
        {
            if (objectiveLocation[i][0] == keyID)
            {
                if (objectiveLocation[i][0] == 1)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                break;
            }
        }
        return result;
    }

    

}
