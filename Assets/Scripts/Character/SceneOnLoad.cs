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
        List<GameObject> enemy = new List<GameObject>();
        for (int i = 0; i < tempList.Length; i++)
        {
            if (tempList[i].GetComponent<EnemyScript>().isAttackEnemy)
            {
                enemy.Add(tempList[i]);
            }
            
        }

        //dog
        tempList = GameObject.FindGameObjectsWithTag("Dog");
        List<GameObject> dog = new List<GameObject>();
        
        for (int i = 0; i < tempList.Length; i++)
        {

            if (tempList[i].GetComponent<DogScript>().onSight)
            {
                dog.Add(tempList[i]);
                
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
                    enemy[j].transform.position = temp[i].transform.position;
                }

                //dog
                for (int j = 0; j < dog.Count; j++)
                {
                    dog[j].transform.position = temp[i].transform.position;
                }

                Transform player = GameObject.FindGameObjectWithTag("Player").transform;
                player.position = temp[i].transform.position;

                break;

            }
 

        }
        GameObject[] tempCharacter = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] tempCamera = GameObject.FindGameObjectsWithTag("MainCamera");
        GameObject[] tempPhoneCanvas = GameObject.FindGameObjectsWithTag("PhoneCanvas");
        GameObject[] tempPhoneEvent = GameObject.FindGameObjectsWithTag("PhoneEvent");

        if (tempCharacter.Length > 1 && tempCamera.Length > 1 && tempPhoneCanvas.Length > 1 && tempPhoneEvent.Length > 1)
        {
            for (int i = 1; i < tempCharacter.Length; i++)
            {
                Destroy(tempCharacter[i]);
                Destroy(tempCamera[i]);
                Destroy(tempPhoneCanvas[i]);
                Destroy(tempPhoneEvent[i]);
            }
            
        }

    }
}
