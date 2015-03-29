using UnityEngine;
using System.Collections;

public class TalkTrigger : MonoBehaviour {

    public bool trigger;
    public bool haveTalk;
    public bool istriggervic;
    public GameController system;
    public tapHelp helpstatus;
    public tapTalk isAlreadyTalk;
	// Use this for initialization
	void Start () {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player" && helpstatus.helpStatus){
            int random = Random.Range(0, 100);
            if (random >= 0)
            {
                trigger = true;
            }
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "VictimTalk")
        {
            TalkTrigger result = col.GetComponent<TalkTrigger>();
            if (result.trigger == true && trigger == true)
            {
                trigger = false;
            }
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            trigger = false;
            haveTalk = false;
        }
        
    }
}
