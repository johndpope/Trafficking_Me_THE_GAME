using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BossQuest : Quest {

    private int bossDestination;
    private bool bossKilled;
    public BossQuest(int questID, string questName, string questDescription, string questStatus, int score, int bossDestination, bool bossKilled)
        : base(questID, questName, questDescription, questStatus, score)
    {
        this.bossDestination = bossDestination;
        this.bossKilled = bossKilled;
    }

    public bool IsInDestination(int mapID)
    {
        bool result = false;
        if (mapID == bossDestination)
        {
            result = true;
        }
        return result;
    }

    public void SetBossKilled()
    {
        bossKilled = true;
    }

    public bool IsBossKilled()
    {
        return bossKilled;
    }


}
