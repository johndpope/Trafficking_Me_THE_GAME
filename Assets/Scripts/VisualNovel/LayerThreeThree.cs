using UnityEngine;
using System.Collections;

public class LayerThreeThree : Story {

	public LayerThreeThree() :
        base("C02_2", "Fight the boss", "Go to the boss room and beat him")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Amata", "Finally, we did it.", "hall", new string[] { "AmataSmileTalk", "MariV2nottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "You keep doing nonsense thing. We almost lose.", "hall", new string[] { "AmataSmile", "MariV2aNGRYtalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "What did you say?", "hall", new string[] { "Amatastupid", "MariV2aNGRY" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Do you get mad... about what I said to you.", "hall", new string[] { "Amatastupid", "MariV2SadTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "I don’t angry over little things.", "hall", new string[] { "AmataSmileTalk", "MariV2Sad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Amata", "Besides, I’m your friend for a long time, I can’t get mad that easy.", "hall", new string[] { "AmataSmileTalk", "MariV2Sad" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "I smile after I heard his word.", "hall", new string[] { "AmataSmile", "MariV2smile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Now, I think that I find the light to bring my dad back to the right side and help my friends.", "hall", new string[] { "AmataSmile", "MariV2smile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "", "To be continue..", "hall", new string[] { }, new Position[] { }, null, null);
    }
}
