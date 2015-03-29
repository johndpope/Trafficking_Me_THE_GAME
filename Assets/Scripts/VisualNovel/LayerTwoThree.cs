using UnityEngine;
using System.Collections;

public class LayerTwoThree : Story {

	public LayerTwoThree()
        : base("B02_2", "Searching for Amata", "Locate and find Amata")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "", "This room is not so big, and looks similar with other rooms.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Eeeeek!!", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I hear the girl scream from this room.", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Amata", "Why’re you did this to me. I trust you!", "jail", new string[] { "AmataAngrytalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "??", "Let me go!", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Amata, stop! You can’t harm the weak girl! I’m wrong. You’re so bad.", "jail", new string[] { "MariV2aNGRYtalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Amata", "What’re you talking, Mali. She’s wicked.", "jail", new string[] { "MariV2aNGRYtalk", "AmataAngrytalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "??", "Help me...", "jail", new string[] { "MariV2aNGRY", "AmataAngry", "maria"}, new Position[] { Position.left, Position.middle, Position.right }, null, null);
        addConversation(1, "Amata", "Don’t believe her. She tricks you.", "jail", new string[] { "MariV2aNGRY", "AmataAngrytalk", "marianottalk" }, new Position[] { Position.left, Position.middle, Position.right }, null, null);
        addConversation(1, "Mali", "No way. It’s not true.", "jail", new string[] { "MariV2aNGRYtalk", "AmataAngry", "marianottalk" }, new Position[] { Position.left, Position.middle, Position.right }, null, null);
        addConversation(1, "??", "Get lost!", "jail", new string[] { "MariV2aNGRY", "AmataAngry", "maria" }, new Position[] { Position.left, Position.middle, Position.right }, null, null);
        addConversation(1, "Amata", "Arkkkkkk", "jail", new string[] { "MariV2aNGRY", "Amatafrighten", "marianottalk" }, new Position[] { Position.left, Position.middle, Position.right }, null, null);
        addConversation(1, "", "This girl pick up the wood and hit Amata on the head, then he fall down and collapse.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Amata!", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "??", "Sorry... I didn’t mean it... I just...", "jail", new string[] { "MariV2frighthened", "maria" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I look at Amata wound, his head is bleeding. He might die if he not treated.", "jail", new string[] { "MariV2Sad", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "???", "Sorry... I’m sorry...", "jail", new string[] { "MariV2Sad", "maria" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Get a hold of yourself. Tell me what’s happen.", "jail", new string[] { "MariV2SadTalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "She tells me that she met with Amata coincidentally. Suddenly, Amata gone weird and attack her. Its make her scare.", "jail", new string[] { "MariV2Sad", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I understand what you are trying to tell me, but...", "jail", new string[] { "MariV2SadTalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Benz and this girl said the same thing. Is it true that Amata gone crazy?", "jail", new string[] { "MariV2Sad", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "We don’t know each other name. What’s your name?", "jail", new string[] { "MariV2", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Maria", "I’m Maria.", "jail", new string[] { "MariV2nottalk", "mariaNormalTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "We’re friends.", "jail", new string[] { "MariV2smiletalk", "mariaNormal" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Maria", "Um", "jail", new string[] { "MariV2smile", "mariaSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "What’re we doing with Amata? Leave him or bring him with us?", "jail", new string[] { "MariV2SadTalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "If he awake, he might attack us. What should we do?", "jail", new string[] { "MariV2SadTalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "!!", "jail", new string[] { "MariV2frighthened", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "", "The criminal intrude into the room, make the situation gone risky.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Bad guys A", "Stop! Little brat!", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "That’s bad.", "jail", new string[] { "MariV2SadTalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Arkkkkkk", "jail", new string[] { "AmataAngrytalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "Amata run into those guys like the beast.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Amata!", "jail", new string[] { "MariV2SadTalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I want to go with Amata but Maria obstruct me and push me out of the room.", "jail", new string[] { "MariV2Sad", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "She lock the door and doesn’t say anything.", "jail", new string[] { "MariV2Sad", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "What’re you doing!?", "jail", new string[] { "MariV2aNGRYtalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "I don’t want you to risk your life. You have many friends who care about you. Unlike me, who has no friend.", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Don’t talk like this. I’m your friend!", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Thanks...", "jail", new string[] { "mariaSmile" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Amata", "You damn girl! Get lost!", "jail", new string[] { "AmataAngrytalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Amata shout from inside the room. He change so much. I never think of him being like this.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Go. Hurry! Your friends are waiting for you.", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Amata is can’t help right now.  What should I do? Help my friends or help Maria?", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);

        addConversation(2, "Mali", "I run to fire exit as fast as I can", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(2, "Mali", "I will come back later and save Maria for sure no matter what.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);

        addConversation(3, "Mali", "I don’t want to leave anyone. I’ll... help Maria…. No matter what!", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Maria", "Mali...", "jail", new string[] { "mariaNormalTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "If I lose someone, I’ll in depress until the rest of my life.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Bad guy A", "Shut up! Bring them to the hall!", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(3, "Maria", "Hurry, before you got caught.", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "I’m not going anywhere! Never!", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Maria", "If you got caught, who’ll help us? So... !!!", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "Maria!", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Bad Guys A", "Get another one!", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(3, "Mali", "I need to escape from here. I run as fast as I can, if I survive, I can help Maria.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "Get another one!", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(3, "Mali", "They bring Maria to the hall, I need to help her.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);

        addChoices(1, "Run to fire exit");
        addChoices(1, "Save maria");
        addAnswer(1, 1, 2, 1, 8);
        addAnswer(1, 1, 3, 1, 9);
    }
}
