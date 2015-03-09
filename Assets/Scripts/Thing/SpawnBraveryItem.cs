using UnityEngine;
using System.Collections;

public class SpawnBraveryItem : MonoBehaviour {

    GameController system;
	// Use this for initialization
	void Start () {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        bool isSpawn = system.HaveToSummonBraveryItem();
        if(isSpawn){
            int random = Random.Range(0,2);
            if (random == 0)
            {
                GameObject corpse = (GameObject)Instantiate(Resources.Load("Prefabs/Corpse"), transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
            }
            else
            {
                GameObject skeleton = (GameObject)Instantiate(Resources.Load("Prefabs/Skeleton"), transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
