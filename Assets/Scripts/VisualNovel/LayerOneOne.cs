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
        addConversation(1, "Mali", "Don’t be afraid. I’m here.", "jail", new string[] { "MariV2" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Friend1", "Mali, Thank you. I almost die. *cry*", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Friend2", "Mommmm *cry*", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Do you know where Amata and others is?", "jail", new string[] { "MariV2" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Friend1", "I don’t know either. But I heard them talking about some of our friends escape.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Friend1", "This one might be Amata, but I think it’s hard to look for him.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Friend2", "Bring us out of here, Mali. I’m scare. *cry*", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "After I took my friends to the safe place, I think that find other friends and escape together might waste the time.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "They can get us anytime if we’re still in there.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Why I not take risk and go to the control room and find something to contact the people outside.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);

        addConversation(2, "Mali", "I’m out of the room, run along the way.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(2, "Mali", "I must contact a police, so I should go to the control room.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(2, "Mali", "That room must has phone or some tool, but it dangerous and I not go inside that easy. I should have some plans.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);

        addConversation(3, "Mali", "I believe that my friends not only in this room, but also in somewhere else.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Friend1", "Where’re you going? Don’t leave me.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(3, "Mali", "I’ll search for others. They should be somewhere.", "jail", new string[] { "MariV2" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Friend1", "It’s so dangerous. Please, don’t go.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(3, "Mali", "I can’t sit by and wait until my beloved friends die.", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "I run immediately, even it dangerous.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);

        addChoices(1, "Contact authority for help");
        addChoices(1, "Search for Amata");
        addAnswer(1, 1, 2, 1, 4);
        addAnswer(1, 2, 3, 1, 5);
    }
}
