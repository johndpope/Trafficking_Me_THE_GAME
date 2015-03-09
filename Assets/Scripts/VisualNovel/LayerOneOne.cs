using UnityEngine;
using System.Collections;

public class LayerOneOne : Story {

    public LayerOneOne()
        : base("A01", "Help your friends", "Investigate the cell room and help your friend")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Maria", "Don't worry, I'm come here to help", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Everyone", "Thank you very much", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Everyone", "**cry cry**", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Do you know where is Amata?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Everyone", "Don't know, but we heard that there is someone can escape like you", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Everyone", "It might be him", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Mari", "I think it would be better to call for help first", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mari", "I can't leave Amata behind, I have to search for him", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addChoices(1, "Contact authority for help");
        addChoices(1, "Search for Amata");
        addAnswer(1, 1, 2, 1, 3);
        addAnswer(1, 2, 3, 1, 4);
    }
}
