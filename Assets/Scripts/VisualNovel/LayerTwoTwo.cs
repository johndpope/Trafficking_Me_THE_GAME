using UnityEngine;
using System.Collections;

public class LayerTwoTwo : Story {

	public LayerTwoTwo()
        : base("B02_1", "Find Amata", "Go to the destination point to see Amata")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mali", "I think that my friends should be around here. I see some clue.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Ah. Someone’s here. He looks so weak. Is he a criminal, or my friend?", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I look around the room, but not see a good place to hide.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "He walks close to me, so I need to move back. He’s breathing so fast, but he doesn’t look like a criminal.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I recognize him suddenly when he is under the light. He isn’t a criminal, he is Benz, one of my classmate.", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Benz, are you all right!", "jail", new string[] { "MariV2" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Benz", "Mali! Are you okay?", "jail", new string[] { "benzHavewoundTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I’m okay. You should worry with yourself.", "jail", new string[] { "MariV2SadTalk", "benzHavewound" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "...", "jail", new string[] { "MariV2Sad", "benzHavewound" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "He immediately collapses. He injures, and need to be treated.", "jail", new string[] { "MariV2Sad", "benzHavewound" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Why’re you in pain like this? Are they assault you?", "jail", new string[] { "MariV2SadTalk", "benzHavewound" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "Not them…", "jail", new string[] { "MariV2Sad", "benzHavewoundTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Then, who did this to you?", "jail", new string[] { "MariV2SadTalk", "benzHavewound" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "It was Amata.", "jail", new string[] { "MariV2Sad", "benzHavewoundTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "No way. He never did this!", "jail", new string[] { "MariV2frighthened", "benzHavewound" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "I know it hard to believe. Even I, his close friend can’t believe it.", "jail", new string[] { "MariV2aNGRY", "benzHavewoundTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "Amata is crazy right now. He attacks me and escape.", "jail", new string[] { "MariV2aNGRY", "benzHavewoundTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Where’s he go?", "jail", new string[] { "MariV2aNGRY", "benzHavewound" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "That way.", "jail", new string[] { "MariV2aNGRYtalk", "benzHavewoundTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "", "Benz points his finger to the right door at the end of the path.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I need to talk with him. I don’t believe until I see him by myself.", "jail", new string[] { "MariV2aNGRYtalk", "benzHavewound" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Benz", "Don’t go. It’s dangerous.", "jail", new string[] { "MariV2aNGRY", "benzHavewoundTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Don’t worry. Just care only yourself.", "jail", new string[] { "MariV2", "benzHavewound" }, new Position[] { Position.left, Position.right }, null, null);

        addChoices(1, "Continue searching for Amata");
        addAnswer(1, 1, 2, 1, 6);

    }
}
