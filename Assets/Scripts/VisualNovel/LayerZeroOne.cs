using UnityEngine;
using System.Collections;

public class LayerZeroOne : Story {

    public LayerZeroOne()   
        : base("P01", "Investigate the sound", "Mari heard someone cry for help, so she decide to see what happen there")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mali", "I see the really long path. I realize that this place is so large and hard to find the way out.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "\"Damn!\"", "jail", new string[] { "MariV2aNGRYtalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Then I hear the voice from the opposite room.", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "??", "\"Eeeeeekkkkkkkk\"", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I decide to go look inside that room to see what really happen there.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        
        
    }
}
