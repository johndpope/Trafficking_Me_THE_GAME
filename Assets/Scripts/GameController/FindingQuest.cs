using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindingQuest : Quest {


    private Dictionary<int, List<ItemQuest>> objectiveLocation; //map that contain this quest
    // item list before random 
    private List<ItemQuest> items;
    private List<int> map;
    public FindingQuest(int questID, string questName, string questDescription, string questStatus, int score) : base(questID, questName, questDescription, questStatus, score) 
    {
        objectiveLocation = new Dictionary<int, List<ItemQuest>>();
        items = new List<ItemQuest>();
        map = new List<int>();
    }
    // 1= true;
    //2 = false;
    public void addItemQuest(ItemQuest item)
    {
        items.Add(item);
    }
    public void addMap(int[] mapID)
    {
        for (int i = 0; i < mapID.Length; i++)
        {
            map.Add(mapID[i]);
        }
    }

    public bool HaveItem(int mapID, Spawn position)
    {
        bool result = false;
        if (objectiveLocation.ContainsKey(mapID))
        {
            for (int i = 0; i < objectiveLocation[mapID].Count; i++)
            {
                if (objectiveLocation[mapID][i].getPositions() == position)
                {
                    result = true;
                    break;
                }
            }
                
        }
        return result;
    }
    public bool IsCollect(int mapID, Spawn position)
    {
        bool result = false;
        if (objectiveLocation.ContainsKey(mapID))
        {
            for (int i = 0; i < objectiveLocation[mapID].Count; i++)
            {
                if (objectiveLocation[mapID][i].getPositions() == position)
                {
                    result = objectiveLocation[mapID][i].getIsCollected();
                    break;
                }
            }
        }
        return result;
    }

    

    public void randomItems()
    {
        while (items.Count >0 && map.Count >0)
        {
            int randomMap = Random.Range(0, map.Count);
            
            //Debug.Log("randomMap" + randomMap);
            if (objectiveLocation.ContainsKey(map[randomMap]))
            {

                if (objectiveLocation[map[randomMap]].Count < 2)
                {
                    
                    int randomItem = Random.Range(0, items.Count);
                    ItemQuest temp = items[randomItem];
                    for (int i = 0; i < objectiveLocation[map[randomMap]].Count; i++)
                    {
                        
                        if (objectiveLocation[map[randomMap]][i].getPositions() == Spawn.one)
                        {
                            temp.setPositions(Spawn.two);
                            break;
                        }
                    }
                    objectiveLocation[map[randomMap]].Add(temp);
                    map.Remove(randomMap);
                    items.Remove(items[randomItem]);
                }
            }
            else
            {
                
                int randomItem = Random.Range(0, items.Count);
                objectiveLocation.Add(map[randomMap], new List<ItemQuest>());
                ItemQuest temp = items[randomItem];
                objectiveLocation[map[randomMap]].Add(temp);
                items.Remove(items[randomItem]);

            }
        }
        foreach (KeyValuePair<int, List<ItemQuest>> pair in objectiveLocation)
        {
            
            for (int i = 0; i < pair.Value.Count; i++)
            {
                Debug.Log(pair.Key + " " + pair.Value[i].getItemID() + " " + pair.Value[i].getPositions());
            }
        }
    }
    public void setIsCollect(int mapID, Spawn position)
    {
        if(objectiveLocation.ContainsKey(mapID)){
            for (int i = 0; i < objectiveLocation[mapID].Count; i++)
            {
                if (objectiveLocation[mapID][i].getPositions() == position)
                {
                    Debug.Log("successful");
                    objectiveLocation[mapID][i].setIsCollected(true);
                }
                
            }
        }
        
    }

    public bool allItemCollected()
    {
        bool result = true;
        
        foreach(KeyValuePair<int,List<ItemQuest>> pair in objectiveLocation){
            for (int i = 0; i < pair.Value.Count; i++)
            {
                if(pair.Value[i].getIsCollected() == false){
                    result = false;
                    break;
                }
            }
        }

        return result;
    }

}
