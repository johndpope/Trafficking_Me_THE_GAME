using UnityEngine;
using System.Collections;

public class checkchangeDes : MonoBehaviour {

	// Use this for initialization
    private string nameQuest;
    private string desQuest;
    private GameController system;
    private checkStory storyChecking;
    private bool isfinish;
	void Start () {
        nameQuest = "Investigate the sound";
        desQuest = "Mari heard someone cry for help, so she decide to see what happen there";
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        storyChecking = GetComponent<checkStory>();
	}
	
	// Update is called once per frame
	void Update () {
        if (storyChecking.visualnovel.activeSelf == false && system.getHaveConversation(storyChecking.mapID) == true && !isfinish)
        {
            isfinish = true;
            system.ChangeQuestDescription(nameQuest, desQuest);
            system.ShowQuestMessage();
        }
	}
}
