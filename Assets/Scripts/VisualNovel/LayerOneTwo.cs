using UnityEngine;
using System.Collections;

public class LayerOneTwo : Story {

	public LayerOneTwo()
        : base("A02", "Find the useful information", "Go to the document room and find the useful information for escape")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mari", "I found the picture of many children including me", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "What really happen here?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "TraffickerA", "Shit! where the hell is that girl", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "TraffickerB", "Don't worry, we will capture her soon", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "TraffickerB", "Let think about transport the victim and heroine first", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "What should I do now", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Mari", "I think I can't handle this alone, let call for a help", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mari", "I can't leave my friend behind, I have to save them before it too late", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addChoices(1, "Contact authority for help");
        addChoices(1, "Destroy trafficker shipment");
        addAnswer(1, 1, 2, 1, 3);
        addAnswer(1, 2, 3, 1, 6);
    }
}
