using UnityEngine;
using System.Collections;

public class LayerThreeFour : Story {

	public LayerThreeFour() :
        base("C03", "Find hiding place", "Find the room for hiding until authority arrived")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mali", "After we go out of that room, we search for the new place to hide and wait for the police.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "We can’t stay in that room because we don’t know when the enemy will wake up.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "We walk pass many rooms, some room has people and some has the way to go through it.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "We stop at one room that looks different from other rooms before.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "The door look so old and the knob full of rust. However, it’s able to open.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "This room looks older than others, because of dust and cobweb around.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I think it isn’t used for a long time. So, we decide to hide in there.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "It should be safe when it not have the path connecting with other rooms.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I lean against the wall, sit with the many boxes which big enough for hide us behind them.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I’m run out of strength and nearly collapse.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Amata sit next to me, I think he should so tired too.", "jail", new string[] { "MariV2Sad", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I never think that I’m still alive.", "jail", new string[] { "MariV2SadTalk", "AmataSad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Don’t worry. I’m right here with you. We’ll get through this.", "jail", new string[] { "MariV2Sad", "AmataSmileTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "You’re too confident.", "jail", new string[] { "MariV2aNGRYtalk", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Why I went red in the face.", "jail", new string[] { "MariV2aNGRY", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Ha Ha I’m always like that.", "jail", new string[] { "MariV2aNGRY", "AmataSmileTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I have something to tell you if we’re unable to get out of here.", "jail", new string[] { "MariV2SadTalk", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "We’ll get away with this!", "jail", new string[] { "MariV2Sad", "Amatatalksmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I...", "jail", new string[] { "MariV2SadTalk", "Amata" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Then we heard the sound of footstep and the doors open by SWAT.", "jail", new string[] { "MariV2Sad", "Amata" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "The police come to help us out of there with my friends and other preys.", "jail", new string[] { "MariV2nottalk", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Those bad guys are arrested, and the one that I hit before look at me angrily with the blood cover his face.", "jail", new string[] { "MariV2nottalk", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I’m frightening, but the police already arrested them, so they can’t do the bad things anymore.", "jail", new string[] { "MariV2nottalk", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "The police interrogate all of us, but some people still freak out and can’t answer anything.", "jail", new string[] { "MariV2nottalk", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I and my friends just only panic a little because we got caught not so long.", "jail", new string[] { "MariV2nottalk", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "However, there is something that I suspect.", "jail", new string[] { "MariV2nottalk", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "One of our friends is missing, it is Benz. After we got caught, no one see him anymore.", "jail", new string[] { "MariV2nottalk", "AmataSmile" }, new Position[] { Position.left, Position.right }, null, null);

        addConversation(1, "", "In the truth, fighting with the criminals is very dangerous.", "jail", new string[] { }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "", "The characters in this story have both luck and environment to support which barely happen in the real situation.", "jail", new string[] { }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "", "There is not much chance to alive after kidnapped.", "jail", new string[] { }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "", "We need to contact the people we can trust, or the one who have power to help.", "jail", new string[] { }, new Position[] { Position.left, Position.right }, null, null);
    }
}
