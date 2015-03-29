using UnityEngine;
using System.Collections;

public class SubStoryOne : Story {

    public SubStoryOne() : base("S01", "Sub story one", "Sub story one description")
    {
        Initial();
    }

    void Initial()
    {
        addConversation(1, "Victim", "Thank for talking with me", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Victim", "I don't want to die!!!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Victim", "Help me or I will kill you", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        
    }
}
