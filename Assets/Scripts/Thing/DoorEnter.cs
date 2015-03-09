using UnityEngine;
using System.Collections;

public class DoorEnter : MonoBehaviour {

	// Use this for initialization
    //public CharacterController player;
    //bool isActivate;
    public string mapName;
    public string nameSummon;
    public SceneOnLoad target;
    public GameObject getIn;
    public bool isLock;
    public bool isRandomEnemy;

	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<SceneOnLoad>();
        getIn.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter2D(Collider2D enter)
    {
        if(enter.tag == "Player" && isLock == false){
            getIn.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D stay)
    {   

        if (stay.tag == "Player" && getIn.GetComponent<TapDoor>().isEnter == true)
        {
           

            target.summon = nameSummon;
            
            Application.LoadLevel(mapName);

        }
    }

    void OnTriggerExit2D(Collider2D exit)
    {
        if(exit.tag == "Player"){
            getIn.SetActive(false);
        }
    }
    
}
