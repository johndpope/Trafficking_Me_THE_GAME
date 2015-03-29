using UnityEngine;
using System.Collections;

public class CheckIntroStory : MonoBehaviour {

	// Use this for initialization
    public GameObject visualnovel;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (visualnovel.activeSelf == false)
        {
            Application.LoadLevel("one");
        }
	}
}
