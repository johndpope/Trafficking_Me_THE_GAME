using UnityEngine;
using System.Collections;

public class DoorEnemy : MonoBehaviour {

	// Use this for initialization
    public GameObject door;
    public bool isFirst = true;
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player" && door.GetComponent<DoorEnter>().isRandomEnemy == true && isFirst == true){
            door.GetComponent<DoorEnter>().isLock = true;
            Debug.Log("enemy coming from door");
            int random = Random.Range(0, 20);
            random = 0;
            if(random == 0){
                isFirst = false;
                door.GetComponent<DoorEnter>().isTriggerEvent = true;
                GameObject.FindGameObjectWithTag("MainCamera").SendMessage("SetEventOccur", true);
                
            }
        }
    }


}
