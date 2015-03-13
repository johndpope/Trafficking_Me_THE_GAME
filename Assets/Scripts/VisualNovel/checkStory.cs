using UnityEngine;
using System.Collections;

public class checkStory : MonoBehaviour {

    public int mapID;
    private GameController system;
    public GameObject visualnovel;
    public int questID; //this conversation belong to which quest
	// Use this for initialization
	void Start () {
        if (visualnovel != null)
        {
            visualnovel.SetActive(false);
        }
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        //Debug.Log(system.getCurrentQuest().QuestID);
        if(system.haveConversation(mapID) && system.getCurrentQuest().QuestID == questID){
            
            if (system.getHaveConversation(mapID) == false)
            {
                Debug.Log("have conversation ");
                visualnovel.SetActive(true);
                system.setHaveConversation(mapID, true);
            }
        }
        else if(system.getCurrentQuest().QuestID != questID){
            //do nothing
        }
        else
        {
            Destroy(visualnovel);
        }
	}
	
}
