using UnityEngine;
using System.Collections;

public class checkTutorial : MonoBehaviour {

    public int mapID;
    private GameController system;
    public int questID;
    private bool trigger;
    public tutorialList tutorials;

	// Use this for initialization
	void Start () {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (system.haveConversation(mapID) && system.getCurrentQuest().QuestID == questID)
        {

            if (system.getHaveConversation(mapID) == false && trigger)
            {
                Debug.Log("have conversation ");
                Tutorial tu = GameObject.FindGameObjectWithTag("PhoneCanvas").GetComponent<PhoneCanvas>().tutorial.GetComponent<Tutorial>();
                tu.setTutorial(tutorials);
                tu.gameObject.SetActive(true);
                system.setHaveConversation(mapID, true);
                Time.timeScale = 0;
            }
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
