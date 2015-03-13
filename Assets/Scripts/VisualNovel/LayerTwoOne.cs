using UnityEngine;
using System.Collections;

public class LayerTwoOne : Story {

    public LayerTwoOne()
        : base("B01", "Contact Authority for help", "Sneak to the control room and find a way to contact authority")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mari", "I pick up a phone and call the police", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Officer, please help me! I was kidnapped. Help me.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Cop", "Calm down, please. Could you tell me any information?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Suddenly, someone drag me and push me down on the floor, while I was telling the story.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Trafficker", "Don’t you dare with me, little brat.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "The giant man points the knife at my neck. I close my eyes with fear, I’m going to die.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "...", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Hey, Mali. Are you all right?", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "That’s Amata’s voice!? I open my eyes slowly and see Amata right in front of me.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "Amata… *cry*", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "It’s okay. The cop got our address.", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Let find some place save until cop arrived", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mari", "OK, let find some place for hiding then", "background", new string[] { "new", "kuy" }, new Position[] { Position.left, Position.right }, null, null);
        addChoices(1,"Find some place save to hide");
        addAnswer(1, 1, 2, 1, 9);

    }
}
