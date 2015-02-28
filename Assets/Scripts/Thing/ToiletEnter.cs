using UnityEngine;
using System.Collections;

public class ToiletEnter : MonoBehaviour {

    public GameObject saveIcon;
	// Use this for initialization
	void Start () {
        saveIcon.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D enter)
    {
        if(enter.tag == "Player"){
            saveIcon.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D exit)
    {
        if(exit.tag == "Player"){
            saveIcon.SetActive(false);
        }
    }
}
