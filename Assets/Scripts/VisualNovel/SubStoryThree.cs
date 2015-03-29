using UnityEngine;
using System.Collections;

public class SubStoryThree : Story {

	public SubStoryThree() : base("S03", "Sub story three", "Sub story three description")
    {
        Initial();
    }

    void Initial()
    {
        addConversation(1, "Victim", "This shirt is black-blue or this shirt is white-yellow", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Victim", "I think it the correct answer", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Victim", "Are you stupid?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addChoices(1, "black-blue");
        addChoices(1, "white-yellow");
        addAnswer(1, 1, 2, 0, 0);
        addAnswer(1, 2, 3, 0, 0);
    }
}
