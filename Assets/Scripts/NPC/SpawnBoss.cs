using UnityEngine;
using System.Collections;

public class SpawnBoss : MonoBehaviour {

	// Use this for initialization
    public GameController system;
    public int mapID;
    public float wallLeft;
    public float wallRight;
    void Start()
    {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        if (system.IsArrive(mapID) && system.IsBossKilled() == false)
        {
            GameObject boss = (GameObject)Instantiate(Resources.Load("Prefabs/Boss"), transform.position + new Vector3(0, 2.5f, 0), Quaternion.Euler(0, 0, 0));
            GameObject.FindGameObjectWithTag("Door").GetComponent<DoorEnter>().isLock = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
