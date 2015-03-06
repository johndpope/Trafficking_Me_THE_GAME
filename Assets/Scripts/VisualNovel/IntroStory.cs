using UnityEngine;
using System.Collections;

public class IntroStory : Story {

    public IntroStory() : base("A01","KUYYYYYY","I don't know")
    {
        Initial();
    }
    public void Initial()
    {
        
        addConversation(1,"Benz", "hello I am Benz","background",new string[]{"new","kuy"},new Position[]{Position.left,Position.right}, "Fate","N");
        addConversation(1, "Benz", "Today I would like to present about game", "background", new string[] { "new", "kuy" }, new Position[] { Position.right, Position.left }, "Fate2", "Fate");
        addConversation(1, "Benz", "My game is...... I don't know. what should I do?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, "Fate", "N");
        addConversation(2, "Benz", "why you are so clue", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, "Fate", "N");
        addConversation(2, "Benz", "I don't know I don't care", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, "Fate", "N");
        addConversation(2, "everyone", "die!!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, "Fate", "N");
        addConversation(3, "Benz", "I don't mind", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, "Fate", "N");
        addConversation(3, "Benz", "I want to.....", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, "Fate", "N");
        addConversation(3, "everyone", "die!!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, "Fate", "N");
        addChoices(1, "get out");
        addChoices(1, "go to the hell");
        addAnswer(1, 1, 2, 0,2);
        addAnswer(1, 2, 3, 1,2);
        setHaveQuestinlastTime(false, 2);
    }
}
