using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneOnLoad : MonoBehaviour {

	// Use this for initialization
    public string summon;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnLevelWasLoaded(int level)
    {
        
        //victim
        GameObject[] tempList = GameObject.FindGameObjectsWithTag("Victim");
        List<Transform> victim = new List<Transform>();

        for (int i = 0; i < tempList.Length; i++)
        {
            if(tempList[i].GetComponent<VictimScript>().popup.helpStatus){
                victim.Add(tempList[i].transform);
            }
        }

        //enemy
        tempList = GameObject.FindGameObjectsWithTag("Enemy");
        List<Transform> enemy = new List<Transform>();
        for (int i = 0; i < tempList.Length; i++)
        {
            if (tempList[i].GetComponent<EnemyScript>().isAttackEnemy)
            {
                enemy.Add(tempList[i].transform);
            }
            
        }

        GameObject[] temp = GameObject.FindGameObjectsWithTag("summonPoint");
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i].name == summon)
            {
                //victim
                for (int j = 0; j < victim.Count; j++)
                {
                    victim[j].position = temp[i].transform.position;
                }

                //enemy
                for (int j = 0; j < enemy.Count; j++)
                {
                    enemy[j].position = temp[i].transform.position;
                }

                Transform player = GameObject.FindGameObjectWithTag("Player").transform;
                player.position = temp[i].transform.position;

            }
 

        }
        GameObject[] tempCharacter = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] tempCamera = GameObject.FindGameObjectsWithTag("MainCamera");

        if (tempCharacter.Length > 1 && tempCamera.Length > 1)
        {
            for (int i = 1; i < tempCharacter.Length; i++)
            {
                Destroy(tempCharacter[i]);
                Destroy(tempCamera[i]);
            }
            
        }

    }
}
