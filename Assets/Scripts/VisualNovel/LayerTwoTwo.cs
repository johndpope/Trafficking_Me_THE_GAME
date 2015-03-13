using UnityEngine;
using System.Collections;

public class LayerTwoTwo : Story {

	public LayerTwoTwo()
        : base("B02_1", "Find Amata", "Go to the destination point to see Amata")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mari", "I think my friend should be around here", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "But I found someone instead and he is Benz", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Benz! Are you alright?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "Mari!? Are you save?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "You should worry about yourself first", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "...", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "What really happen to you?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "Amata hurt me", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "I don't believe it. Amata won't do something like that", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "I understand it hard to believe, but he become insane right now", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Where is he right now? I need to talk to him", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "He go through that door", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "I think you shouldn't go look for him", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Mari", "It alright, you take care of yourself", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addChoices(1, "Continue searching for Amata");
        addAnswer(1, 1, 2, 1, 5);

    }
}
