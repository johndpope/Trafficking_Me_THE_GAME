using UnityEngine;
using System.Collections;

public class alereffect : MonoBehaviour {

	// Use this for initialization
    private GameController  system;
    public GameObject alert;
	void Start () {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
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
