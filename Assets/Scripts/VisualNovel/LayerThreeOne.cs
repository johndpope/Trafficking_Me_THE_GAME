using UnityEngine;
using System.Collections;

public class LayerThreeOne : Story {

    public LayerThreeOne() :
        base("C01", "Find the exit door", "Find the exit door to escape from this place")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mali", "Finally, I get off this place and safe.", "jail", new string[] { "MariV2smile" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "??", "Stop.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "!!", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Someone follow me and talk from behind.", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "You!!", "jail", new string[] { "MariV2aNGRYtalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "They are two men who fight with Maria. So she is...", "jail", new string[] { "MariV2aNGRY" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "What about Maria! Is she safe!?", "jail", new string[] { "MariV2aNGRYtalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Bad Guys A", "Don’t worry. She’s here!!", "jail", new string[] { "MariV2smile" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "!!", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Maria become a hostage, the knife is point to her neck.", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Bad Guys A", "Don’t move, or this girl die!!", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Maria", "Don’t care about me. Run...", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Bad Guys B", "Shut up, brat.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Those guys punch Maria’s stomach harshly.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I really scare of them, my legs shaking of fear. I don’t know what to do for help her.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Bad Guys A", "Look at her. Nearly collapse.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "When am I falling down? They walk nearer and nearer to catch me, who out of strength.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Bad Guys B", "Ow!!", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Maria", "Mali!!", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "Maria use all her strength crunch on the guy’s foot.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "They release her because of pain, and then she run to hold me who in sorrow.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Maria!", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "You should be good girl from now.", "jail", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Eh?", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Eeeeeeeekkk!!!", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I feel that lighting run though my body.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Then I collapse to the ground, completely worn out.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "The show is over.", "jail", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "The show.. What.? I try to lift my head up to see her.", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "She sways the stunt gun like a professional. She uses it with me.", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "What.. does.. it .. mean..?", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Everything I did is all acting.", "jail", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "I act like I want to help you, become a hostage and even told you \"don’t worry about me. go away\".", "jail", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "It’s so hilarious I can’t stop laughing. Do you think I’m really your friend? For me, the cockroach is better than you.", "jail", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Bad Guys A", "Maria, you’re so great in act.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Maria", "Sure. I can do anything for 'that' guy’s wish.", "jail", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "She trick me... all time.. I always think you’re...", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Look. She is crying.", "jail", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "What a good girl you are.", "jail", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Have you ever seen stranger risk their life to help each other?", "jail", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "No way! I really hate the one like you!", "jail", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I can’t do anything.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "What a good girl you are.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "I feel like my heart break apart.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "How can I do?", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "I lose consciousness and everything turns into darkness.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "To be continue...", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);

    }
}
