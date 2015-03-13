using UnityEngine;
using System.Collections;

public enum SpawnV
{
    one,
    two
}

public class Victim {

    private int victimID;
    private bool isHelp;
    private bool isEscort;
    private SpawnV position;

    public Victim(int victimID, bool isHelp, bool isEscort, SpawnV position)
    {
        this.victimID = victimID;
        this.isHelp = isHelp;
        this.isEscort = isEscort;
        this.position = position;
    }

    public void setVictimID(int victimID)
    {
        this.victimID = victimID;
    }

    public int getVictimID()
    {
        return victimID;
    }

    public void setIsHelp(bool isHelp)
    {
        this.isHelp = isHelp;
    }

    public bool getIsHelp()
    {
        return isHelp;
    }

    public void setIsEscort(bool isEscort)
    {
        this.isEscort = isEscort;
    }

    public bool getIsEscort()
    {
        return isEscort;
    }

    public void setPositions(SpawnV position)
    {
        this.position = position;
    }

    public SpawnV getPositions()
    {
        return position;
    }
}
