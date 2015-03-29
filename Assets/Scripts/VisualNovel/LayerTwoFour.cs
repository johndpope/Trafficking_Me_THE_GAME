using UnityEngine;
using System.Collections;

public class LayerTwoFour : Story {

	public LayerTwoFour()
        : base("B03", "Sabotage trafficker shipment", "Find the item for destroy the trafficker shipment")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mali", "We are ready to do as plan. We need to do before the bad guys come.", "jail", new string[] { "MariV2nottalk", "mariaNormal" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "This match is so wet. It’s hard to burn.", "jail", new string[] { "MariV2SadTalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Maria", "We don’t have the time to complain. Hurry up.", "jail", new string[] { "MariV2Sad", "maria" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Finally, the match is work. We must escape of this room.", "jail", new string[] { "MariV2Sad", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Maria. Let’s go.", "jail", new string[] { "MariV2SadTalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Maria", "Okay.", "jail", new string[] { "MariV2Sad", "maria" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "??", "Stop! Don’t move!", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali/Maria", "!!", "jail", new string[] { "MariV2frighthened", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Bad Guys A", "What the crazy thing you do.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "We won’t let you take our friends away.", "jail", new string[] { "MariV2aNGRYtalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Bad Guys B", "I don’t care about your friends! We must stop the fire before it too late.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Maria", "I’m not let you do that!", "jail", new string[] { "MariV2aNGRY", "maria" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "", "Maria doesn’t care about herself and use all of her strength to stop those guys.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Maria!", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Don’t worry. Run! Run as far as you can!", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "But...", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Go! Now!!", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);

        addConversation(2, "Mali", "I run to the jail but no one in there, even Amata and Benz.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(2, "Mali", "Where are they? Are they already escape?", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(2, "??", "Catch them all!", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(2, "Mali", "I hear the shout of bad guys. I must escape.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(2, "Mali", "They shout out “Catch them all”, its mean everyone are safe. I need to hurry too.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);

        addChoices(1, "Find the way out");
        addAnswer(1, 1, 2, 1, 8);

    }
}
