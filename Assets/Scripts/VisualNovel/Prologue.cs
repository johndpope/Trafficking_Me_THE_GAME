using UnityEngine;
using System.Collections;

public class Prologue : Story {

    public Prologue() : base("A00","Prologue","Intro of the story and tutorial")
    {
        Initial();
    }

    public void Initial()
    {
        /*addConversation(1, "", "Today is the last orientation day of Mali’s junior high school. This is the last day that she and her friends are together.", "school", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "After graduated, all of them will be separated to the different senior high school and may be never met again.", "school", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "At the time when last orientation is finished and everyone is going back home, one of her classmate “Benz” is saying...", "school", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Benz", "Hey guys, this is our last day together. Let’s hangout somewhere around. Do you agree ?", "school", new string[] { "benzTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "The rest", "Agreed, but where will we go?", "school", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Benz", "I’m thinking about barbecue restaurant near Si-lom, or some night-karaoke on Ratchada road.", "school", new string[] { "benzTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "The rest", "It’s hard to decide, both choices are very interesting.", "school", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I’m so sorry, I can’t hang out with you tonight. I have to go back home or I will be grounded by my parent.", "school", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Benz", "Nah… We may never meet each other again, just one night. Please...", "school", new string[] { "benzTalk", "MariV2Sad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "But … It’s dangerous in the night.", "school", new string[] { "benzsmile", "MariV2SadTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Don’t be afraid, I will take care of you guys. Trust me !!", "school", new string[] { "AmataSmileTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Benz", "Don't get cocky. You was just crying after hit by our teacher.", "school", new string[] { "benzTalk", "Amatastupid" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "", "Everyone is laughing loud. Armata is embarassing and trying to shade himself off.", "school", new string[] { }, new Position[] { }, null, null);

        addConversation(1, "Mali", "Let’s ask Armata.", "school", new string[] { "MariV2" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Amata", "barbecue !!", "school", new string[] { "AmataSmileTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "Armata suddenly standup when he has a chance to speak.", "school", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "After that, everyone is going to barbecue restaurant.", "restaurant", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "Armata really like barbecue, but Mali doesn’t like it that much.", "restaurant", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "They enjoy eating, drinking, and talk to each other.", "restaurant", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "Some of them are crying because they may not have a chance to see each other again.", "restaurant", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Benz", "Everybody, we are graduated. Cheers !!", "restaurant", new string[] { "benzTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "The rest", "Cheers !!", "restaurant", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Amata", "It’s very delicious. Who will pay for this ?", "restaurant", new string[] { "Amatatalksmile" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Benz", "You sit on the edge, you must pay.", "restaurant", new string[] { "benzTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Everyone must shared.", "restaurant", new string[] { "MariV2aNGRYtalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Benz & Amata", "That’s not fun.", "restaurant", new string[] { "benzbuu", "Amata" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "What’s wrong ? We have to paid.", "restaurant", new string[] { "MariV2aNGRYtalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Benz", "Just kidding, it’s up to you.", "restaurant", new string[] { "AmataSmileTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "Mali is feeling confused, she saw everything is shaking. Then she’s asking a question...", "restaurant", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Armata, why it’s shaking. Is it an earthquake ?", "restaurant", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Amata", "I doesn’t feel anything.", "restaurant", new string[] { "Amatatalksmile", "MariV2Sad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "", "Suddenly Mali is losing her conciousness and falling down. Then everyone is falling too.", "restaurant", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "Only Armata that’s still standing in this weird situation. Someone is breaching into the room !!!", "restaurant", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Amata", "Who are you !!!", "restaurant", new string[] { "AmataSadtalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "???", "...", "restaurant", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "", "Armata is hit on his stomach.", "restaurant", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Amata", "You… !", "restaurant", new string[] { "AmataAngrytalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "Then he is also losing his conciousness like his friends.", "restaurant", new string[] { }, new Position[] { }, null, null);*/

        //let skip intro story and begin the game 
        addConversation(1, "Mali", "When I awake, I found myself was bundled in the dark, dirty room. Why I’m here?", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "!!", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "What’s happen!  Why my hands and legs were bundled like this?", "jail", new string[] { "MariV2frighthened" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I try to think, but I can’t remember why I’m here.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "When I look around, I see my girls classmate and others girls was bundled like me.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "How should I do!? I can’t ask for anyone’s help.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "My friends are depress. They are looking at me like they want me to help.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "", "Few minutes later, the door open and dreadful man walks in. They look at the girls in weird way.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Please, don’t look at me. That’s too bad, his eyes stop at me.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "He makes the frightful smile and unties the rope. I’m scare.", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "??", "\"Come on!\"", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Ouch! I never suffer this awful thing. Even my parents never drag me like I’m animal.", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "He brings me to the room beside and throws me harmfully.", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "This room is smaller than the room before. I sense that the bad thing will happens.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Then this man start to touch my face and body. He breathes harder and harder.", "jail", new string[] { "MariV2Sad" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "??", "*breathes*", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "It’s so disgusting. I’m going to die!? No! I don’t want to die…. My dad, my mom helps me!", "jail", new string[] { "MariV2Cry" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "??", "*ring*", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "Suddenly, his radio communication is ringing. He stops touching my face and answer it.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I only have the thought about get away from here before I was killed. I need to do something.", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I look around the room and see the pipe. I pick it up and hit him on the head after he finish talking.", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "\"Hwakkkkkk\"", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I not hesitate to beat him until he collapse.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "After that, I freaking out and can’t remember how many times I hit him.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "\"What should I do.. What am I doing… \"", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "Five minute after that, I try to keep calm and think of what I need to do.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I search this man for something to help me leave here.", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "\"!?\"", "jail", new string[] { }, new Position[] { }, null, null);
        addConversation(1, "Mali", "I find his mobile phone, but it not has any signal so I can’t ask someone for help. I sigh.", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "*sigh*", "jail", new string[] { "MariV2SadTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I decide to keep it. It might be useful in the future.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I unlock and run away from the room, because I never know when the man will awake or when his colleagues enter the room. ", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
    }
}
