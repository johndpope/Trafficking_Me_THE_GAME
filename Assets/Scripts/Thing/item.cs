using UnityEngine;
using System.Collections;

public class item : MonoBehaviour {

	// Use this for initialization
    public bool isinSideBox;
    public GameObject popup;
    public int mapID;
    public Spawn position;
    GameController gameController;
	void Start () {
        popup.SetActive(false);
        gameController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(popup.GetComponent<tappopup>().isCollected){
            gameController.SetHaveItem(mapID, position);
            gameObject.SetActive(false);
            popup.SetActive(false);
           
            
        }
	}

    void OnTriggerStay2D(Collider2D enter){
        
    }

    void OnTriggerEnter2D(Collider2D enter)
    {
        if (enter.tag == "Player")
        {
            isinSideBox = true;
            popup.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D exit)
    {
        if (exit.tag == "Player")
        {
            isinSideBox = false;
            popup.SetActive(false);
        }
        
    }

    
}


