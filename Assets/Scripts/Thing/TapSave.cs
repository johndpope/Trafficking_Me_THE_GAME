using UnityEngine;
using System.Collections;

public class TapSave : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            if (Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)) &&
                Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)).tag == "Save")
            {
                Debug.Log("save game!!");

            }
        }
    }
}
