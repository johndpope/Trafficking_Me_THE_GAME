using UnityEngine;
using System.Collections;

public class SpawnBraveryItem : MonoBehaviour {

    GameController system;
	// Use this for initialization
	void Start () {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        bool isSpawn = system.HaveToSummonBraveryItem();
        if(isSpawn){
            int random = Random.Range(0,3);
            /*if (random == 0)
            {
                GameObject corpse = (GameObject)Instantiate(Resources.Load("Prefabs/Corpse"), transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
            }
            else
            {
                GameObject skeleton = (GameObject)Instantiate(Resources.Load("Prefabs/Skeleton"), transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
            }*/
            switch (random)
            {
                case 0: 
                    GameObject corpse = (GameObject)Instantiate(Resources.Load("Prefabs/Corpse"), transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
                    break;
                case 1:
                    GameObject skeleton = (GameObject)Instantiate(Resources.Load("Prefabs/Skeleton"), transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
                    break;
                default:
                    GameObject skull = (GameObject)Instantiate(Resources.Load("Prefabs/skull"), transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
                    break;

            }
            
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
