using UnityEngine;
using System.Collections;

public class ToiletExit : MonoBehaviour {

	// Use this for initialization
    public SceneOnLoad target;
    public GameObject getIn;
    public GameController gameController;
	void Start () {
        gameController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<SceneOnLoad>();
        getIn.SetActive(false);

                
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D enter)
    {
        if (enter.tag == "Player")
        {
            getIn.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D stay)
    {

        if (stay.tag == "Player" && getIn.GetComponent<TapDoor>().isEnter == true)
        {

            target.summon = "toiletpoint";

            Application.LoadLevel(gameController.previousMap);

        }
    }

    void OnTriggerExit2D(Collider2D exit)
    {
        if (exit.tag == "Player")
        {
            getIn.SetActive(false);
        }
    }
}
