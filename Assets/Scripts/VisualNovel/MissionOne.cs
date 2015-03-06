using UnityEngine;
using System.Collections;

public class MissionOne : Story {

	// Use this for initialization
    public MissionOne() : base ("B01","Go to hell!!","Find the way to hell as fast as you can")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Amata", "Welcome to hell!!! hahahah", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right },null,null);
        addConversation(1, "Amata", "My name is Amata and I want to f*** with you", "background", new string[] { "new", "kuy" }, new Position[] { Position.right, Position.left },null,null);
        addConversation(1, "Amata", "I will give you a choice for u to choose, choose it wisely", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right },null,null);
        addConversation(2, "Amata", "I think you make a right decision hahah", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right },null,null);
        addConversation(2, "Amata", "OK then let begin shall we?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right },null,null);
        addConversation(2, "Mari", "***censored***", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right },null,null);
        addConversation(2, "everyone", "happy end?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right },null,null);
        addConversation(3, "Amata", "Fine, I will kill you", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right },null,null);
        addConversation(3, "Amata", "Then, I will turn you into zombie and f*** with you hahaha", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right },null,null);
        addConversation(3, "everyone", "Bad End?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right },null,null);
        addChoices(1, "sixtynine");
        addChoices(1, "die!!!");
        addAnswer(1, 1, 2, 0, 1);
        addAnswer(1, 2, 3, 0, 1);
    }
}
