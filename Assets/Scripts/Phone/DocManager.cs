using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DocManager
{
    Dictionary<int, bool> DocCollection;
	// Use this for initialization
    public DocManager()
    {
        DocCollection = new Dictionary<int, bool>();
        createDocCollection();
	}
    public void createDocCollection()
    {
        for (int i = 0; i < 7; i++)
        {
            DocCollection.Add(i, false);
        }
    }

    public bool isDocCollected(int key)
    {
        return DocCollection[key];
    }

    public void collectDoc(int key, bool item)
    {
        DocCollection[key] = item;
    }

	// Use this for initialization
    public int getCountData()
    {
        return DocCollection.Count;
    }
}
