using UnityEngine;
using System.Collections;

public class SummonMonster : MonoBehaviour {

	// Use this for initialization
    private GameController gameController;
    public GameObject objectSummon;
	void Start () {
        gameController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        if (gameController.HavetoSummonEnemy())
        {
            Instantiate(objectSummon, transform.position, Quaternion.identity);
        }
	}
}
