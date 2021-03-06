﻿using UnityEngine;
using System.Collections;

public class SpawnItem : MonoBehaviour {

    public int mapID;
    public Spawn position;
    private GameController system;
	// Use this for initialization
	void Start () {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        string items = "";
        if(system.IsItemInQuest(mapID,position, out items)){
            if (!system.isAlreadyHaveItem(mapID, position))
            {
                GameObject item = (GameObject)Instantiate(Resources.Load("Prefabs/"+items), transform.position + new Vector3(0, 0.5f, 0), Quaternion.Euler(0, 0, 0));
                item a = item.GetComponent<item>();
                a.mapID = mapID;
                a.position = position;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
