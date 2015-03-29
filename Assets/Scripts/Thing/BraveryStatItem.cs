using UnityEngine;
using System.Collections;

public class BraveryStatItem : MonoBehaviour
{

    // Use this for initialization
    GameObject player;
    public bool isFound;
    GameObject system;
    void Start()
    {
        isFound = false;
        player = GameObject.FindGameObjectWithTag("Player");
        system = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D enter)
    {
        if (enter.gameObject.tag == "Player")
        {
            //Debug.Log(player.GetComponent<CharacterEmotion>().getBravery());
            if (!isFound && system.GetComponent<GameController>().immuneCorpse == false)
            {
                Debug.Log("corpse!!!!");
                isFound = true;
                player.GetComponent<CharacterEmotion>().updateStat(StatList.bravery, -1, true);
                player.GetComponent<CharacterEmotion>().firstTimeCorpse = true;
                system.SendMessage("FoundCorpse", true);

                system.SendMessage("IsStatChange", "-1 bravery");

            }
        }
    }
}
