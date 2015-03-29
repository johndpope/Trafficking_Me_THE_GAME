using UnityEngine;
using System.Collections;

public class checkStoryTypeTwo : MonoBehaviour {

	// Use this for initialization
    public int mapID;
    private GameController system;
    public GameObject visualnovel;
    public int questID; //this conversation belong to which quest
    private bool isAlert;
    // Use this for initialization
    private bool trigger;
    private bool showAlert;
	void Start () {
        isAlert = false;
        if (visualnovel != null)
        {
            visualnovel.SetActive(false);
        }
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (showAlert == true && !isAlert && visualnovel.activeSelf == false )
        {
            Debug.Log("game object");
            if (GameObject.FindGameObjectsWithTag("Enemy") != null)
            {
                GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
                for (int i = 0; i < enemy.Length; i++)
                {
                    EnemyScript temp = enemy[i].GetComponent<EnemyScript>();
                    temp.isAttackEnemy = true;
                }
                
            }
            system.SetAlert(true);
            isAlert = true;
            Destroy(visualnovel);
        }
        if (system.haveConversation(mapID) && system.getCurrentQuest().QuestID == questID && !system.isAlert)
        {

            if (system.getHaveConversation(mapID) == false && trigger)
            {
                Debug.Log("have conversation ");
                visualnovel.SetActive(true);
                system.setHaveConversation(mapID, true);
                showAlert = true;
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
