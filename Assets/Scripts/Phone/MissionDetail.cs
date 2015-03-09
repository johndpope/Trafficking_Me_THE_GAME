using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MissionDetail : MonoBehaviour {

	// Use this for initialization
    GameController gameSystem;
    public Text topic;
    public Text description;
    public Quest current;
	void Start () {
        gameSystem = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        current = gameSystem.getCurrentQuest();
        topic.text = current.QuestName;
        description.text = current.QuestDescription;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
