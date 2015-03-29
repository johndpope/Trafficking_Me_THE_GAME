using UnityEngine;
using System.Collections;

public class tapTalk : MonoBehaviour {

    public bool isTalk;
    public bool firstTime = true;
    public GameObject talkTrigger;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && firstTime == true)
        {
            if (Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)) &&
                Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)).name == "talk_icon")
            {
                isTalk = true;
                firstTime = false;
                talkTrigger.SetActive(false);

            }
        }
	}
}
