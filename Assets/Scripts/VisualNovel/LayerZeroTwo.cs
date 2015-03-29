using UnityEngine;
using System.Collections;

public class LayerZeroTwo : Story {

    public LayerZeroTwo()
        : base("P02", "Escape and help girl victim undetected", "You alerted an enemy, escape as fast as you can and come back to save victim later")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mali", "I try to look inside and see few of men torture the girl around 19 years old.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Those guys are looking at me, so I immediately close and lock the door.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Then run away as far as I can.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "*alert sound*", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "The siren is alert.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I guess that it alert because the enemy found me.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "My heart beat so fast, I’m very scared.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I need to escape at all cost.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        setHaveQuestinlastTime(true, 1);
    }
}
