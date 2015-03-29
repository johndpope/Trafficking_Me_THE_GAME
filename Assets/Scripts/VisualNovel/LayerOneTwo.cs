using UnityEngine;
using System.Collections;

public class LayerOneTwo : Story {

	public LayerOneTwo()
        : base("A02", "Find the useful information", "Go to the document room and find the useful information for escape")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mali", "I walk to the document storage room.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Inside there have a lot of bookshelf, but have only few of books.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Besides, it really dirty like never cleans before. I don’t want to go inside.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "It’s not the time for disgust.", "jail", new string[] { "MariV2aNGRY" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I saw the hell before, this room is better than that. I need to hurry and find the document.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I pick up the document one by one. I don’t see anything that can help us. Most of them are blank pages.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "Thud!*", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Eeek", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Shut the mouth. Don’t make any noise. What’s fall down from above, it make me frightened.", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "It is an old file which has photo of 9-10 years old children inside it.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Why my old photo is here!?", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "It has my photo when I’m younger than now and also my friends, together with photo of other children.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "What does it mean? It’s so weird.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "*Screech*", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "The door open, someone go inside there.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I need to hide. I walk lightly to the dark corner of the room.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I see the shadow of few people doing something, and then walk out of the room.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Bad Guys A", "Where’re those brats? How can I report to our boss?", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Bad Guys B", "Calm down, man. There’re hiding somewhere. Never go upstairs.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Bad Guys A", "Dammit! I’ll catch them and make them see the hell!", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Bad Guys B", "We’ll transport heroines and those brats. We need to hurry and catch them.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "After that, they’re going outside the room.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "They’ll transport my friends for doing something. I need to help my friends… but how can I do anything.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I must call the police first, they’ll help us.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "But if they not come on time, how should I do?", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);

        addConversation(2, "Mali", "I must contact a police, so I should go to the control room.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(2, "Mali", "That room must has phone or some tool, but it dangerous and I not go inside that easy. ", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(2, "Mali", "I should have some plans.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);

        addConversation(3, "Mali", "I deicided to help my friend.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "I can’t stand to see my friend disappear forever.", "jail", new string[] { "MariV2aNGRY" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "I must hurry now to rescue them.", "jail", new string[] { "MariV2aNGRY" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "!!", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "Someone grab my hands behind me while I was standing. Are they find me?", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "??", "Don’t be scare.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(3, "Mali", "You! I met you before.", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "??", "Don’t speak so loud, they’ll hear us.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(3, "Mali", "I understand, but why you’re here? If anything happen to you…", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Girl Prey", "I worry about you… and I don’t want to do nothing while you’re facing the difficult.", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "You...", "jail", new string[] { "MariV2SadTalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "Ah! We don’t know each other.", "jail", new string[] { "MariV2frighthened", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "What’s your name?", "jail", new string[] { "MariV2", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Maria", "I’m Maria, and you?", "jail", new string[] { "MariV2nottalk", "mariaNormalTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "I’m Mali. We’re friends now.", "jail", new string[] { "MariV2smiletalk", "mariaNormal" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Maria", "Um!", "jail", new string[] { "MariV2smile", "mariaSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "We’re smile to each other in such a bad situation.", "jail", new string[] { "MariV2smile", "mariaSmileNottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "It’s weird but that’s because I think we can do.", "jail", new string[] { "MariV2smile", "mariaSmileNottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "What are we going to do? I don’t have any plan.", "jail", new string[] { "MariV2", "mariaNormal" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Maria", "I just heard them few second ago. I need a time to think.", "jail", new string[] { "MariV2nottalk", "mariaNormalTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Maria", "I think we should make some chaos in their storage.", "jail", new string[] { "MariV2nottalk", "mariaNormalTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "Your idea is great. If we make a mess in the room, they can’t transport anything.", "jail", new string[] { "MariV2", "mariaNormal" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Maria", "But how can we do it? We don’t have anything.", "jail", new string[] { "MariV2nottalk", "maria" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "I have some idea. If we set fire on, they’ll panic for sure.", "jail", new string[] { "MariV2", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Maria", "Okay. Let’s do it.", "jail", new string[] { "MariV2nottalk", "mariaNormalTalk" }, new Position[] { Position.left, Position.right }, null, null);
        
        addChoices(1, "Contact the police");
        addChoices(1, "Help friends(destroy heroines)");
        addAnswer(1, 1, 2, 1, 4);
        addAnswer(1, 2, 3, 1, 7);
    }
}
