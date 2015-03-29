using UnityEngine;
using System.Collections;

public class checkStory : MonoBehaviour {

    public int mapID;
    private GameController system;
    public GameObject visualnovel;
    public int questID; //this conversation belong to which quest
	// Use this for initialization
    private bool trigger;
    public bool haveTutorial = false;
    private bool isShowQuest = false;
    private bool finishTutorial = false;
	void Start () {
        if (visualnovel != null)
        {
            visualnovel.SetActive(false);
        }
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        //Debug.Log(system.getCurrentQuest().QuestID);
        /*if(system.haveConversation(mapID) && system.getCurrentQuest().QuestID == questID){
            
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
        }*/
	}

    void Update()
    {
        if (system.haveConversation(mapID) && system.getCurrentQuest().QuestID == questID && !system.isAlert)
        {

            if (system.getHaveConversation(mapID) == false && trigger)
            {
                Debug.Log("have conversation ");
                visualnovel.SetActive(true);
                system.setHaveConversation(mapID, true);
            }
        }
        else if (system.getCurrentQuest().QuestID != questID)
        {
            //do nothing
        }
        else
        {
            Destroy(visualnovel);
        }
        if (system.getHaveConversation(mapID) == true && visualnovel.activeSelf == false && haveTutorial)
        {
            PhoneCanvas turtorial = GameObject.FindGameObjectWithTag("PhoneCanvas").GetComponent<PhoneCanvas>();
            turtorial.tutorial.SetActive(true);
            haveTutorial = false;
        }
        if (system.getHaveConversation(mapID) == true && visualnovel.activeSelf == false && finishTutorial == false)
        {
            PhoneCanvas turtorial = GameObject.FindGameObjectWithTag("PhoneCanvas").GetComponent<PhoneCanvas>();
            if(turtorial.tutorial.activeSelf == false){
                finishTutorial = true;
            }
            
        }
        if (system.getHaveConversation(mapID) == true && visualnovel.activeSelf == false && finishTutorial == true && !isShowQuest)
        {
            system.ShowQuestMessage();
            isShowQuest = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            trigger = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
            trigger = false;
    }
}
