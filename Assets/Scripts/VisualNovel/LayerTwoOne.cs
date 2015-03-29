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
        addConversation(1, "Mali", "I hurry to pick up a phone, and call the police immediately.", "controlroom", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Officer, please help me! I was kidnapped. Help me.", "controlroom", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Cop", "Calm down, please. Could you tell me any information?", "controlroom", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Well...", "controlroom", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "!!", "controlroom", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Someone drag me and push me down on the floor, while I was telling the story.", "controlroom", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "??", "\"Don’t you dare with me, little brat.\"", "controlroom", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Dammit. I got caught, he’ll kill me.", "controlroom", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "The giant man points the knife at my neck. I close my eyes with fear, I’m going to die.", "controlroom", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "...", "controlroom", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Amata", "Hey, Mali. Are you all right?", "controlroom", new string[] { "Amatatalksmile" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "That’s Amata’s voice!? I open my eyes slowly and see Amata right in front of me.", "controlroom", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Amata… *cry*", "controlroom", new string[] { "MariV2Cry", "Amata" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I accidentally hug him and cry until my eyes swelling.", "controlroom", new string[] { "MariV2Cry", "Amata" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "After that, Amata called the police to tell our address when I calm myself.", "controlroom", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Amata", "It’s okay. The cop got our address.", "controlroom", new string[] { "MariV2nottalk", "Amatatalksmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Amata looking at me and reach his hand to me.", "controlroom", new string[] { "MariV2nottalk", "Amata" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Let’s go.", "controlroom", new string[] { "MariV2nottalk", "AmataSmileTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Um.", "controlroom", new string[] { "MariV2smiletalk", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "We walk out of the room together.", "controlroom", new string[] { "MariV2smile", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        
        addChoices(1,"Find save place for hiding");
        addAnswer(1, 1, 2, 1, 10);

    }
}
