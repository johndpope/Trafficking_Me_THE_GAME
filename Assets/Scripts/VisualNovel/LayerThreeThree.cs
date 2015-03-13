using UnityEngine;
using System.Collections;

public class LayerThreeThree : Story {

	public LayerThreeThree() :
        base("C02_2", "Fight the boss", "Go to the boss room and beat him")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Amata", "Finally, we win!!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "What are you doing. We almost defeat.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "What~~~", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Aren't you angry me?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "I don't mind this little thing beside I have known you for too long", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "I smile a little bit", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "I believe that there will be a way to save everyone", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Game", "To be continue..", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
    }
}
