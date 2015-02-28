using UnityEngine;
using System.Collections;

public class TapDoor : MonoBehaviour {

    public bool isEnter;
	// Use this for initialization
	void Start () {
        isEnter = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            
            Collider2D temp = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            //Debug.Log("position " + Input.mousePosition + " " + Camera.main.ScreenToWorldPoint(Input.mousePosition) + " " + temp);

            
            if (temp != null)
            {
                
                if (temp.tag == "GetIn")
                    //Debug.Log("collider name " + temp.name);
                    isEnter = true;
                
                
            }
        }
	}


}
