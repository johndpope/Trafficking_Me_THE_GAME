using UnityEngine;
using System.Collections;

public class LayerThreeFour : Story {

	public LayerThreeFour() :
        base("C03", "Find hiding place", "Find the room for hiding until authority arrived")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mari", "I think we may not make it.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Don’t worry. I’m right here with you. We’ll get through this.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "You’re too confident.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Why I went red in the face.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Ha Ha I’m always like that.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "I have something to tell you if we’re unable to get out of here.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "We’ll get away with this!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "I…", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Then we heard the sound of footstep and the doors open by SWAT.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Game", "**skip ending story 5555**", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
    }
}
