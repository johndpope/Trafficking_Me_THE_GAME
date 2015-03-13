using UnityEngine;
using System.Collections;

public class LayerTwoFour : Story {

	public LayerTwoFour()
        : base("B03", "Sabotage trafficker shipment", "Find the item for destroy the trafficker shipment")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mari", "Let burn them all haha", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "**Let skip the story for a while**", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "What are we going to do next", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "OK, let get out from this place.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null); 
        addChoices(1, "Find the way out");
        addAnswer(1, 1, 2, 1, 7);

    }
}
