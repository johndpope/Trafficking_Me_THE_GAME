using UnityEngine;
using System.Collections;

public class checkStoryByClick : MonoBehaviour {
    public int mapID;
    private GameController system;
    public GameObject visualnovel;
	// Use this for initialization
	void Start () {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        visualnovel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (system.getHaveConversation(mapID) == false && Input.GetMouseButton(0) && Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)).name == "questPopup")
        {
            visualnovel.SetActive(true);
        }
	}
}
