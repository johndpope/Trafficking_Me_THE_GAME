using UnityEngine;
using System.Collections;

public class LayerThreeTwo : Story {

	public LayerThreeTwo() :
        base("C02_1", "Fight the boss", "Go to the boss room and beat him")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mali", "I sneak into the dark hall, it has only small light.", "hall", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "??", "This room not change, old and dirty.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "There is someone right here before me. His voice is so familiar, I used to hear it many times.", "hall", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Dad...", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali’s Dad", "Long time no see, Mali. No, just a few days.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Why’re you here?", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali’s Dad", "Don’t come closer. There is electricity in the water on the floor.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I miss you so much. Since you have an accident and died two years ago.", "hall", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I never forget how kind of you. If you still alive, you should contact me...", "hall", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali's Dad", "Sorry, I have reason.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "What reason? Is it more important than family!?", "hall", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali's Dad", "You don’t’ need to know, because in a few moments, you’ll be with your friends.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "The lights turn up. I see the large cage behind dad. Everyone was captured inside it.", "hall", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Friend A", "Mali! Help me!", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Friend B", "Mali! Mali!", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali's Dad", "If you want to help them, kill me.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "What’s you mean!? I don’t understand.", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Dad throws a pistol to my side.", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali's Dad", "It’s time to choose. Shoot me if you want your friends survive.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "!?", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali's Dad", "You know, dead alive is hurt more than the real dead. Hurry and shot me.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I hear my friends asking for help. Why my dad become like this? He is so serious about this thing.", "hall", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali's Dad", "Long time ago, I bought many girls from savage parents who sold their own child.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali's Dad", "I think that they are so cruel, but I’m cruel more than them.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "!!", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali's Dad", "I use them like a toy. I punish them badly when they’re not following my order.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali's Dad", "Do you know, I never felt pity! I feel great like I’m in heaven.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali's Dad", "When they escape, I shoot them with no hesitate!", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Dad!", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali's Dad", "Do it! Shoot your beloved dad!!", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "You’re so cruel. You’re not my dad, just the devil from the hell.", "hall", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali's Dad", "Shoot me, Mali! What’re you waiting for!? Shoot me!", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali's Dad", "I’ll count from 5 to 1, then shoot. ", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali's Dad", "\"5\"", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali's Dad", "\"4\"", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali's Dad", "\"3\"", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali's Dad", "\"2\"", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali's Dad", "\"1\"", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Dad!!", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I can’t do this, I can’t shoot my father. I can’t decide to kill someone.", "hall", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I sit on the floor by shock, my hand are shaking.", "hall", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali's Dad", "I’m disappointed in you.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Then the cage that contains my friends lift up.", "hall", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "I’m back, master!", "hall", new string[] { "mariaNormalTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali’s Dad", "You’re too late.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Maria", "Sorry, I got some problems.", "hall", new string[] { "mariaNormalTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Maria?", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Why Maria talk with my dad like they’re so close? Isn’t she a hostage?", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "At first, I want to set up a situation that a guy name Amata becomes a bad man, but it not good.", "hall", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "So, I change the plan to see some impressed scene.", "hall", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Is that true? Everything is lie.", "hall", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Everything is a lie.", "hall", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Whoever wants to be a friend with a dirty cockroach like you.", "hall", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "You!!", "hall", new string[] { "MariV2aNGRYtalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Oh. Don’t points a gun like this. It’s dangerous.", "hall", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Maria locks me while I holding a gun, and she take it from me easily.", "hall", new string[] { "MariV2aNGRY" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Don’t doing anything stupid if you don’t want to get hurt.", "hall", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I can’t do anything, even help my friends.", "hall", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "The one who would die should be me.", "hall", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali’s Dad", "So, I got to go. I leave the rest to you.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Maria", "Yes, sir.", "hall", new string[] { "mariaNormalTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Maria", "What’s happen?", "hall", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Amata", "Arkk!", "hall", new string[] { "AmataAngrytalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "Amata run to Maria and hit her head by the stick, but she can dodge.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Maria", "Amata?! No way, how can he go here?", "hall", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Amata", "I just have something to help.", "hall", new string[] { "Amatatalksmile" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "Dammit. Everyone get him!", "hall", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "The giant guys come out and attack Amata harmfully.", "hall", new string[] { }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Maria", "I leave the rest to you, my servant.", "hall", new string[] { "mariaEnemyModetalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "Maria gone with the darkness, leave the giant guys attack us continually.", "hall", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Amata", "Don’t be still. Let’s escape.", "hall", new string[] { "AmataSadtalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I don’t have any strength...", "hall", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Amata", "What’re you talking!?", "hall", new string[] { "MariV2Sad", "AmataSadtalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Amata drag me to somewhere we can hide from them.", "hall", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Get a hold of yourself. We need to help our friends.", "hall", new string[] { "MariV2Sad", "AmataSadtalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Help?", "hall", new string[] { "MariV2SadTalk", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I used to think about it, but I can’t. Even my dad is with their side. I don’t have anything anymore.", "hall", new string[] { "MariV2SadTalk", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Are you crazy!!", "hall", new string[] { "MariV2Sad", "Amatafrighten" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "If you think like that again, I’ll punch you. Do you think you don’t have anything?", "hall", new string[] { "MariV2Sad", "AmataSadtalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "It’s not true. You have me and many people who care about you. Don’t give up.", "hall", new string[] { "MariV2Sad", "AmataSadtalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "But...", "hall", new string[] { "MariV2SadTalk", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "No excuse. Let’s fight together.", "hall", new string[] { "MariV2Sad", "Amatatalksmile" }, new Position[] { Position.left, Position.right }, null, null);
    
    }
}
