using UnityEngine;
using System.Collections;

public class LayerTwoThree : Story {

	public LayerTwoThree()
        : base("B02_1", "Searching for Amata", "Locate and find Amata")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Amata", "Why are you doing right this? I trusted you.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "???", "Leave me", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Amata hurt the girl victim that I saved", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Amata stop! You hurt the girl that can't fight you", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "???", "Help me....", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "You shouldn't believe her, she is the liar.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Suddenly, this girl hit Amata with timber", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "???", "I'm so sorry. I didn't mean to", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "It okay now. Calm down and tell me the story", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "???", "My name is maria and ... (lazy to translate haha)", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "**skip the story**", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Mari", "I will find someone to help you as fast as I can", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Benz", "I won't leave you behind", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addChoices(1, "Find the way out");
        addChoices(1, "Save maria");
        addAnswer(1, 1, 2, 1, 7);
        addAnswer(1, 1, 3, 1, 8);

    }
}
