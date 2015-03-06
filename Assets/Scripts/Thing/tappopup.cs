using UnityEngine;
using System.Collections;

public class tappopup : MonoBehaviour {

	// Use this for initialization
    public bool isCollected;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetMouseButtonDown(0)){
            if(Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)) &&
                Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)).tag == "Popget"){
                isCollected = true;

            }
        }
	}

    

    
    
}
