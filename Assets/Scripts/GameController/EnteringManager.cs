using UnityEngine;
using System.Collections;

public class EnteringManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void TapEnterButton()
    {
        GameObject tapDoor = GameObject.FindGameObjectWithTag("GetIn");
        if (tapDoor != null)
        {
            tapDoor.GetComponent<TapDoor>().EnteringClick();
        }

        GameObject tapGet = GameObject.FindGameObjectWithTag("Popget");
        if (tapGet != null)
        {
            tapGet.GetComponent<tappopup>().EnteringClick();
        }

        GameObject tapLockerIn = GameObject.FindGameObjectWithTag("LockerIn");
        if (tapLockerIn != null)
        {
            tapLockerIn.GetComponent<taplocker>().EnteringClick();
        }

        GameObject tapLockerOut = GameObject.FindGameObjectWithTag("LockerOut");
        if (tapLockerOut != null)
        {
            tapLockerOut.GetComponent<taplocker>().EnteringClick();
        }
    }
}
