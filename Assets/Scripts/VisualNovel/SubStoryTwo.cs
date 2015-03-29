using UnityEngine;
using System.Collections;

public class SubStoryTwo : Story {

	public SubStoryTwo() : base("S02", "Sub story two", "Sub story two description")
    {
        Initial();
    }

    void Initial()
    {
        addConversation(1, "Victim", "Hello do you think we gonna escape", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Victim", "Thank you for give me hope, love u jub jub", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Victim", "Suicide!!!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addChoices(1, "Yes");
        addChoices(1, "No");
        addAnswer(1, 1, 2, 0, 101);
        addAnswer(1, 2, 3, 0, 102);
    }


}
