using UnityEngine;
using System.Collections;

public class BossScript : MonoBehaviour {

    float speed = 5.0f;
    float wallLeft = 22.0f;
    float wallRight = 30.0f;
    GameObject player;
    float faceDirection = 1.0f;
    int hp = 100;
    GameObject haveConversation;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        haveConversation = GameObject.FindGameObjectWithTag("HaveConversation");
        StoryDependent temp = haveConversation.GetComponent<StoryDependent>();
        temp.visualnovel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (hp <= 0)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>().UpdateBossStatus();
            GameObject.FindGameObjectWithTag("Door").GetComponent<DoorEnter>().isLock = false;
            Destroy(gameObject);
            StoryDependent temp = haveConversation.GetComponent<StoryDependent>();
            temp.visualnovel.SetActive(true);
        }
        else
        {
            transform.Translate(new Vector2(speed * faceDirection * Time.deltaTime, 0));
            if (faceDirection > 0 && transform.position.x > wallRight)
            {
                faceDirection = -1.0f;

            }
            else if (faceDirection < 0 && transform.position.x < wallLeft)
            {
                faceDirection = 1.0f;
            }
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player"){
            hp -= 20;
            Debug.Log(hp);
        }
    }
}
