using UnityEngine;
using System.Collections;

public class warningEffect : MonoBehaviour {
    private GameController system;
    public GameObject warning;
	// Use this for initialization
	void Start () {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        warning.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (system.getWarning())
        {
            warning.SetActive(true);
        }
        else
        {
            warning.SetActive(false);
        }
	}
    void OnLevelWasLoaded(int level)
    {
        if (system == null)
        {
            system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        }
    }
}
