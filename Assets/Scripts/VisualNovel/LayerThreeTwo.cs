using UnityEngine;
using System.Collections;

public class LayerThreeTwo : Story {

	public LayerThreeTwo() :
        base("C02_1", "Fight the boss", "Go to the boss room and beat him")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mari", "We arrived at hall room", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Suddenly, there is a big guy with knife coming in", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "He must be the boss of trafficker", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Boss", "I will kill you all!!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Let fight them together!!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        
    }
}
