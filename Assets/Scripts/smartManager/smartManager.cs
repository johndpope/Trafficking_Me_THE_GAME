using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class smartManager  {
    Dictionary<string, int> mapDictionary;
    public smartManager()
    {
        mapDictionary = new Dictionary<string, int>();
        Initial();
    }
    public void Initial()
    {
        mapDictionary.Add("one", 0);
        mapDictionary.Add("two", 0);
        mapDictionary.Add("three", 0);
        mapDictionary.Add("four", 0);
        mapDictionary.Add("five", 0);
        mapDictionary.Add("six", 0);
        mapDictionary.Add("seven", 0);
        mapDictionary.Add("eight", 0);
        mapDictionary.Add("nine", 0);
        mapDictionary.Add("ten", 0);
        mapDictionary.Add("eleven", 0);
        mapDictionary.Add("twelve", 0);
        mapDictionary.Add("thirteen", 0);
        mapDictionary.Add("fourteen", 0);
        mapDictionary.Add("fifteen", 0);
        mapDictionary.Add("sixteen", 0);
        mapDictionary.Add("seventeen", 0);
        mapDictionary.Add("eighteen", 0);
        mapDictionary.Add("nineteen", 0);
        mapDictionary.Add("twenty", 0);
        mapDictionary.Add("twentyone", 0);
        mapDictionary.Add("twentytwo", 0);
        mapDictionary.Add("twentythree", 0);
        mapDictionary.Add("twentyfour", 0);
        mapDictionary.Add("twentyfive", 0);
        mapDictionary.Add("twentysix", 0);
        mapDictionary.Add("twentyseven", 0);
        mapDictionary.Add("twentyeight", 0);
        mapDictionary.Add("twentynine", 0);
        mapDictionary.Add("thirty", 0);
        mapDictionary.Add("thirtyone", 0);
        mapDictionary.Add("thirtytwo", 0);
        mapDictionary.Add("thirtyfour", 0);
        mapDictionary.Add("thirtyfive-thirtyseven", 0);
    }
    public void addChanceValue(string map, int n)
    {
        if (mapDictionary.ContainsKey(map))
        {
            mapDictionary[map] += n;
        }
    }
    public void decreaseChaneValue(string map, int n)
    {
        if (mapDictionary.ContainsKey(map))
        {
            if (mapDictionary[map] - n > 0)
            {
                mapDictionary[map] -= n;
            }
            else
            {
                mapDictionary[map] = 0;
            }
            
        }
    }
    public void addAllChanceValue(int n)
    {
        foreach (KeyValuePair<string, int> pair in mapDictionary)
        {
            if (mapDictionary[pair.Key] + n < 100)
            {
                mapDictionary[pair.Key] += n;
            }
            else
            {
                mapDictionary[pair.Key] = 100;
            }
        }
    }
    public int getChanceValue(string map)
    {
        if (mapDictionary.ContainsKey(map))
        {
            return mapDictionary[map];
        }
        else
        {
            return 0;
        }
    }
    public void decreaseAllChanceValue(int n)
    {
        foreach (KeyValuePair<string, int> pair in mapDictionary)
        {
            if (mapDictionary[pair.Key] - n > 0)
            {
                mapDictionary[pair.Key] -= n;
            }
            else
            {
                mapDictionary[pair.Key] = 0;
            }
        }
    }
    public void getAllChanceValue(out string[] map, out int[] n)
    {
        List<string> tempMap = new List<string>();
        List<int> tempValue = new List<int>();
        foreach (KeyValuePair<string, int> pair in mapDictionary)
        {
            tempMap.Add(pair.Key);
            tempValue.Add(pair.Value);
        }
        map = tempMap.ToArray();
        n = tempValue.ToArray();
    }
    public void setChanceValue(string map, int n)
    {
        mapDictionary[map] = n;
    }
    public void addanddereaseALLchanceValue(string map, int increase, int decrease)
    {
        foreach (KeyValuePair<string, int> pair in mapDictionary)
        {
            if (pair.Key == map)
            {
                mapDictionary[pair.Key] += increase;
            }
            else
            {
                mapDictionary[pair.Key] -= decrease;
            }
            
        }
    }
}
