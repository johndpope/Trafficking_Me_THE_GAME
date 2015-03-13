using UnityEngine;
using System.Collections;

public class LayerOne : Story {

	public LayerOne() : base("A00","Layer one mission","Select the route of mission one")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Maria", "Thank for your help", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Never mind, do you know where the other victim were hold", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Maria", "Yes, they were hold in the cell which have heavily guard", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Maria", "I think it too risky, let find the way out first", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Mari", "I can make my friend stay in this place any longer, I have to help them", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Maria", "Fine, I wish you have a good luck", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mari", "Ok then, let find the way out first and contact the help later", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Maria", "Good choice, try to be safe and good luck", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addChoices(1, "Try to find other friend");
        addChoices(1, "Find the document or information for an escape");
        addAnswer(1, 1, 2, 1, 1);
        addAnswer(1, 2, 3, 1, 2);

    
    }
}
