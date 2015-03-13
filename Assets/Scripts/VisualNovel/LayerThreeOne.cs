using UnityEngine;
using System.Collections;

public class LayerThreeOne : Story {

    public LayerThreeOne() :
        base("C01", "Find the exit door", "Find the exit door to escape from this place")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mari", "Finally, we did it. Now we are free.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "???", "Stop right there.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "You!!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "It the trafficker that capture maria", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Is Maria save?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "TraffickerA", "Don't worry, she is here", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "**skip story**", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Suddenly, Maria shock me with electricity", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Maria", "Sorry Mari. I have to do this in order to become free", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Game", "To be continue...","background" ,new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        
    }
}
