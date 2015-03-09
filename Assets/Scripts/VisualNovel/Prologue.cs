using UnityEngine;
using System.Collections;

public class Prologue : Story {

    public Prologue() : base("A00","Prologue","Intro of the story and tutorial")
    {
        Initial();
    }

    public void Initial()
    {
        //let skip intro story and begin the game 
        addConversation(1, "Mari", "Where am I here?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "I was tied inside an old dark room", "background", new string[] { "new", "kuy" }, new Position[] { Position.right, Position.left }, null, null);
        addConversation(1, "Mari", "I look around the room and found my female classmate was tied like me", "background", new string[] { "new", "kuy" }, new Position[] { Position.right, Position.left }, null, null);
        addConversation(1, "Effect", "**Door open**", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "There is horrible man coming and he stare at me", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "???", "Come here!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "He un-tied the rope and take me to other room", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "???", "You are so cute", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "???", "**Terrible breath sound**", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Am I going to die, I don't want to die!!", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Effect", "**Walky Talky sound**", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "???", "Tch, interrupt my feeling", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "He turn back and answer his walky talky", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "I found a giant pipe, so I hit this horrible man", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "He knockdown and went unconscious", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "It time to figure the way out of here", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
    }
}
