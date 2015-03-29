using UnityEngine;
using System.Collections;

public class checkStoryByClick : MonoBehaviour {
    public int mapID;
    private GameController system;
    public GameObject visualnovel;
    public bool trigger;
    public int questID;
    public string nameObject = "questPopup";
    private bool isalreadyClick;
	// Use this for initialization
	void Start () {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        visualnovel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (system.getCurrentQuest().QuestID != questID)
        {
            //do nothing
        }
        else if (!isalreadyClick && system.getHaveConversation(mapID) == false && Input.GetMouseButton(0) && Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)).name == nameObject && !system.isAlert && trigger)
        {
            visualnovel.SetActive(true);
            isalreadyClick = true;
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
