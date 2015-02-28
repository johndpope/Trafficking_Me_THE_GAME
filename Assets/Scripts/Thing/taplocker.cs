using UnityEngine;
using System.Collections;

public class taplocker : MonoBehaviour {

    public bool inLocker;
    public taplocker oppositeTap;
	// Use this for initialization
	void Start () {
        inLocker = false;
        oppositeTap = oppositeTap.GetComponent<taplocker>();

	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)) &&
                (Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)).name == "get in" ||
                Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)).name == "get out"))
            {
                inLocker = !inLocker;
                oppositeTap.inLocker = inLocker;
            }

        }
    }
}
