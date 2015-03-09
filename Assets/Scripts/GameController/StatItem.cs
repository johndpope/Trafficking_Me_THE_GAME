using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StatItem {

    Dictionary<int, bool> statItem;
	// Use this for initialization
	public StatItem() {
        statItem = new Dictionary<int, bool>();
	}

    public void addStatItem()
    {
        for (int i = 0; i < 30; i++)
        {
            statItem.Add(i, false);
        }
    }

    public bool getStatItem(int key)
    {
        return statItem[key];
    }

    public void changeStatItem(int key, bool item)
    {
        statItem[key] = item;
    }
}
