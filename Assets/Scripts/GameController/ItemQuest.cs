using UnityEngine;
using System.Collections;
public enum Spawn
{
    one,
    two
}

public class ItemQuest {
    private int itemID;
    private string prefab;
    private bool isCollected;
    private Spawn position;
    public ItemQuest(int itemID,string prefab,bool isCollect, Spawn position){
        this.itemID = itemID;
        this.prefab = prefab;
        this.isCollected = isCollect;
        this.position = position;
    }


    public void setItemID(int itemID)
    {
        this.itemID = itemID;
    }

    public int getItemID()
    {
        return itemID;
    }

    public void setPrefab(string prefab)
    {
        this.prefab = prefab;
    }

    public string getPRefab()
    {
        return prefab;
    }

    public void setIsCollected(bool isCollected)
    {
        this.isCollected = isCollected;
    }

    public bool getIsCollected()
    {
        return isCollected;
    }

    public void setPositions(Spawn position)
    {
        this.position = position;
    }

    public Spawn getPositions()
    {
        return position;
    }
    
}
