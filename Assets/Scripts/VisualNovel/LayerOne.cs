using UnityEngine;
using System.Collections;

public class LayerOne : Story {

	public LayerOne() : base("A00","Layer one mission","Select the route of mission one")
    {
        Initial();
    }

    public void Initial()
    {
        addConversation(1, "Mali", "Do you know where it is? What happen with us and who are they?", "jail", new string[] { "MariV2" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Girl’s prey", "I don’t know where this place is.", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Girl’s prey", "I’m the foreigner who follows the agent to work as the waitress in Thailand.", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Girl’s prey", "They told me I’ll earn a lot of money, but it’s not true.", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Girl’s prey", "I was forced to sign the eight years contract and become a whore.", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Girl’s prey", "I was caged here every night after finished the work. If I refuse to work or some night not has any customer, I was tortured.", "jail", new string[] { "maria" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Girl’s prey", "And why’re you here?", "jail", new string[] { "mariaNormalTalk" }, new Position[] { Position.middle }, null, null);
        addConversation(1, "Mali", "I absolutely don’t know why I’m here.", "jail", new string[] { "MariV2SadTalk", "mariaNormal" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "The last thing I remember is I have barbecue party with my friend, and then I lose conscious", "jail", new string[] { "MariV2SadTalk", "mariaNormal" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Mali", "Do you know where the others were caged? My friends might be I there.", "jail", new string[] { "MariV2", "mariaNormal" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Girl’s prey", "As far as I know, most of them were caged in the faraway room.", "jail", new string[] { "MariV2nottalk", "mariaNormalTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(1, "Girl’s prey", "It was protect by the best guards and very dangerous. You better not go.", "jail", new string[] { "MariV2nottalk", "maria" }, new Position[] { Position.left, Position.right }, null, null);

        addConversation(2, "Mali", "Um! Thank you so much. I’ll take a risk.", "jail", new string[] { "MariV2smiletalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Mali", "You should find somewhere to hide. After I help my friends, I’ll get you and we’ll escape together.", "jail", new string[] { "MariV2smiletalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Girl’s prey", "Thank, but I was injured so can’t move anymore. You better go first and ask someone to help me.", "jail", new string[] { "MariV2smile", "mariaSmile" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(2, "Mali", "That’s okay.", "jail", new string[] { "MariV2", "mariaSmileNottalk" }, new Position[] { Position.left, Position.right }, null, null);

        addConversation(3, "Mali", "Um! Thank you so much. I’ll take that risk.", "jail", new string[] { "MariV2smiletalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "So, you find a place to hide and I’ll find documents for escape. Then I’ll help my friends.", "jail", new string[] { "MariV2smiletalk", "marianottalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Girl Prey", "Good luck. I can’t walk anymore…", "jail", new string[] { "MariV2smile", "mariaNormalTalk" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "Find the safe place to hide. I’ll be back to help you.", "jail", new string[] { "MariV2", "mariaNormal" }, new Position[] { Position.left, Position.right }, null, null);
        addConversation(3, "Mali", "I think I should find the document first.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);
        addConversation(3, "Mali", "If I go to help my friends right now, it likes I’m dance with death.", "jail", new string[] { "MariV2nottalk" }, new Position[] { Position.middle }, null, null);

        addChoices(1, "Help your friend");
        addChoices(1, "Find information for an escape");
        addAnswer(1, 1, 2, 1, 2);
        addAnswer(1, 2, 3, 1, 3);

    
    }
}
