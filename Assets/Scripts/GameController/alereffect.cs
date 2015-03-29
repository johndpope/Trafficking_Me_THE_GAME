using UnityEngine;
using System.Collections;

public class alereffect : MonoBehaviour {

	// Use this for initialization
    private GameController  system;
    public GameObject alert;
	void Start () {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        alert.SetActive(false);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (system == null)
        {
            system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        }
        else
        {
            if (system.isAlert)
            {
                alert.SetActive(true);
            }
            else
            {
                alert.SetActive(false);
            }
        }
        
	}
    /*void OnLevelWasLoaded(int level)
    {
        if (system == null)
        {
            system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        }
    }*/
}
