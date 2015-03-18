using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VictimList  {

    Dictionary<int, List<Victim>> victimList;
    private List<Victim> victim;
    private List<List<int>> map;
    public VictimList() { 
        victimList = new Dictionary<int,List<Victim>>();
        victim = new List<Victim>();
        map = new List<List<int>>();
    }

    public void addVictim(Victim v)
    {
        victim.Add(v);
    }

    public void addMap(int[] mapID, int[] spawnNum)
    {
        for (int i = 0; i < mapID.Length; i++)
        {
            List<int> temp = new List<int>();
            temp.Add(mapID[i]);
            temp.Add(spawnNum[i]);
            map.Add(temp);
        }

        
    }


    public bool haveVictim(int mapID, SpawnV position)
    {
        bool result = false;

        if(victimList.ContainsKey(mapID)){
            for (int i = 0; i < victimList[mapID].Count; i++)
            {
                if (victimList[mapID][i].getPositions() == position)
                {
                    result = true;
                    break;
                }
            }
        }

        return result;
    }

    //check that this victim is already help or not
    public bool IsHelp(int mapID, SpawnV position)
    {
        bool result = false;
        if (victimList.ContainsKey(mapID))
        {
            for (int i = 0; i < victimList[mapID].Count; i++)
            {
                if (victimList[mapID][i].getPositions() == position)
                {
                    result = victimList[mapID][i].getIsHelp();
                    break;
                }
            }
        }
        return result;
    }

    //help successful, but not escort yet
    public void setIsHelp(int mapID, SpawnV position)
    {
        if (victimList.ContainsKey(mapID))
        {
            for (int i = 0; i < victimList[mapID].Count; i++)
            {
                if (victimList[mapID][i].getPositions() == position)
                {
                    victimList[mapID][i].setIsHelp(true);
                }

            }
        }

    }

    //when victim was capture by enemy, make victim disappear and go back to spawn point
    public void setHelpFail(int mapID, int victimID)
    {
        if(victimList.ContainsKey(mapID)){
            for (int i = 0; i < victimList[mapID].Count; i++)
            {
                if (victimList[mapID][i].getVictimID() == victimID)
                {
                    victimList[mapID][i].setIsHelp(false);
                }
            }
        }
    }

    public void setIsEscort(int mapID, int victimID)
    {
        if(victimList.ContainsKey(mapID)){
            for (int i = 0; i < victimList[mapID].Count; i++)
            {
                if (victimList[mapID][i].getVictimID() == victimID)
                {
                    victimList[mapID][i].setIsEscort(true);
                }
            }
        }
    }

    public void randomVictim()
    {
        while(victim.Count > 0 && map.Count > 0){
            int randomMap = Random.Range(0, map.Count);

            if (victimList.ContainsKey(map[randomMap][0]))
            {
                if(victimList[map[randomMap][0]].Count < 2 && map[randomMap][1] == 2){

                    int randomVictim = Random.Range(0, victim.Count);
                    Victim temp = victim[randomVictim];
                    for (int i = 0; i < victimList[map[randomMap][0]].Count; i++)
                    {

                        if (victimList[map[randomMap][0]][i].getPositions() == SpawnV.one)
                        {
                            temp.setPositions(SpawnV.two);
                            break;
                        }
                    }
                    victimList[map[randomMap][0]].Add(temp);
                    map[0].Remove(randomMap);
                    victim.Remove(victim[randomVictim]);
                }
                else if(victimList[map[randomMap][0]].Count < 1 && map[randomMap][1] == 1){

                    int randomVictim = Random.Range(0, victim.Count);
                    Victim temp = victim[randomVictim];
                    victimList[map[randomMap][0]].Add(temp);
                    map[0].Remove(randomMap);
                    victim.Remove(victim[randomVictim]);

                }
                
            }
            else
            {

                int randomVictim = Random.Range(0, victim.Count);
                victimList.Add(map[randomMap][0], new List<Victim>());
                Victim temp = victim[randomVictim];
                victimList[map[randomMap][0]].Add(temp);
                victim.Remove(victim[randomVictim]);

            }
        }

        /*foreach (KeyValuePair<int, List<Victim>> pair in victimList)
        {

            for (int i = 0; i < pair.Value.Count; i++)
            {
                Debug.Log(pair.Key + " " + pair.Value[i].getVictimID() + " " + pair.Value[i].getPositions());
            }
        }*/
    }

    public int getVictimID(int mapID, SpawnV postion)
    {
        int victimID = 0;
        foreach (KeyValuePair<int, List<Victim>> pair in victimList)
        {

            for (int i = 0; i < pair.Value.Count; i++)
            {
                if (pair.Key == mapID && pair.Value[i].getPositions() == postion)
                {
                    victimID = pair.Value[i].getVictimID();
                }
            }
        }
        return victimID;
    }
    public int[] getVictimID()
    {
        List<int> tempID = new List<int>();
        foreach (KeyValuePair<int, List<Victim>> pair in victimList)
        {
            List<Victim> temp = pair.Value;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].getIsHelp() == true)
                {
                    tempID.Add(temp[i].getVictimID());
                }
            }
        }
        return tempID.ToArray();
    }
    public void setVictimisCollectbyID(int id, bool n)
    {
        foreach (KeyValuePair<int, List<Victim>> pair in victimList)
        {
            List<Victim> temp = pair.Value;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].getVictimID() == id)
                {
                    temp[i].setIsHelp(n);
                }
            }
        }
    }
}
