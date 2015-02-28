using UnityEngine;
using System.Collections;

public class checkStory : MonoBehaviour {

    public int mapID;
    private GameController system;
    public GameObject visualnovel;
	// Use this for initialization
	void Start () {
        if (visualnovel != null)
        {
            visualnovel.SetActive(false);
        }
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        if(system.haveConversation(mapID)){
            
            if (system.getHaveConversation(mapID) == false)
            {
                Debug.Log("have conversation ");
                visualnovel.SetActive(true);
                system.setHaveConversation(mapID, true);
            }
        }
        else
        {
            Destroy(visualnovel);
        }
	}
	
}
