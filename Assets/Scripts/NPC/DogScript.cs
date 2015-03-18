using UnityEngine;
using System.Collections;

public class DogScript : MonoBehaviour {

	// Use this for initialization
    float normalSpeed = 5.0f;
    float runningSpeed = 10.0f;
    public float wallLeft = -5.0f;
    public float wallRight = 5.0f;
    public bool isAttackEnemy;
    public bool onSight;

    GameObject player;
    float faceDirection = 1.0f; //default face right
    Vector2 direction;
    public bool enemyMoveUp;
    public bool enemyMoveDown;
    public Transform currentLadder;
    public Transform currentDoor;
    public Transform ground;
    bool ladderArrive;
    public LayerMask whatIsPlayer;
    public bool inActive;
    public string spawnScreen;
    public string ID;
    bool victimInLocker;
    GameObject[] allEnemy;
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        GameObject[] friend = GameObject.FindGameObjectsWithTag("Dog");
        for (int i = 0; i < friend.Length; i++)
        {
            Physics2D.IgnoreCollision(gameObject.collider2D, friend[i].collider2D);
        }
        allEnemy = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < allEnemy.Length; i++)
        {
            Physics2D.IgnoreCollision(gameObject.collider2D, allEnemy[i].collider2D);
        }

        
	}


    void Update()
    {
        if (Application.isLoadingLevel && onSight)
        {
            DontDestroyOnLoad(gameObject);
            rigidbody2D.velocity = Vector2.zero;
        }
        else if (Application.isLoadingLevel && !onSight)
        {
            Destroy(gameObject);
        }
    }

    

	// Update is called once per frame
	void FixedUpdate () {
        if (inActive)
        {
            //do nothing
            Physics2D.IgnoreCollision(player.collider2D, collider2D);

        }
        else
        {
            if (!isAttackEnemy)
            {
                Physics2D.IgnoreCollision(player.collider2D, collider2D);
                Moving();
            }
            else
            {
                if (isAttackEnemy && player.renderer.enabled == false)
                {
                    Physics2D.IgnoreCollision(player.collider2D, collider2D);
                    if(Mathf.Abs(transform.position.x - player.transform.position.x) < 0.5){
                        victimInLocker = true;
                        transform.Translate(new Vector3(0, 0, 0));
                        Debug.Log("call enemy to locker");

                        for (int i = 0; i < allEnemy.Length; i++)
                        {
                            allEnemy[i].GetComponent<EnemyScript>().isAttackEnemy = true;
                        }
                    }
                }
                else
                {
                    Physics2D.IgnoreCollision(player.collider2D, collider2D, false);
                    victimInLocker = false;
                }

                
            }


            direction = new Vector2(faceDirection, 0);

            DetectPlayer();
            DetectEnemyUpDown();
            MoveToPlayer();
        }

	}

    void Flip()
    {

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void Moving()
    {
        
        if (spawnScreen != Application.loadedLevelName)
        {
            if (currentDoor == null)
            {
                FindDoor();
            }
            MoveToDoor();
        }
        else
        {
            transform.Translate(new Vector2(normalSpeed * faceDirection * Time.deltaTime, rigidbody2D.velocity.y));
            if (faceDirection > 0 && transform.position.x > wallRight)
            {
                faceDirection = -1.0f;
                Flip();

            }
            else if (faceDirection < 0 && transform.position.x < wallLeft)
            {
                faceDirection = 1.0f;
                Flip();

            }
        }
    }

    void DetectPlayer()
    {
        RaycastHit2D hitSomething = Physics2D.Raycast(transform.position, direction, 3.0f, whatIsPlayer);
        
        if (hitSomething.collider != null)
        {
            if (hitSomething.collider.gameObject.tag == "Player" && player.renderer.enabled)
            {
                GameObject.FindGameObjectWithTag("MainCamera").SendMessage("SetAlert", true);
                isAttackEnemy = true;
                onSight = true;
            }
            else
            {
                onSight = false;
            }
        }
        else
        {
            onSight = false;
        }
    }

    void MoveToPlayer()
    {
        if(isAttackEnemy && !victimInLocker){
            if (enemyMoveDown || enemyMoveUp)
            {
                FindNearestLadder();

                if (!ladderArrive)
                {
                    if (currentLadder.transform.position.x > transform.position.x)
                    {
                        transform.Translate(new Vector3(runningSpeed * 1.0f * Time.deltaTime, 0, 0));
                        if (faceDirection != 1.0f)
                        {
                            Flip();
                            faceDirection = 1.0f;
                        }
                    }
                    else if (currentLadder.transform.position.x < transform.position.x)
                    {

                        transform.Translate(new Vector3(runningSpeed * -1.0f * Time.deltaTime, 0, 0));
                        if (faceDirection == 1.0f)
                        {
                            faceDirection = -1.0f;
                            Flip();
                        }
                    }
                }
                else
                {
                    //stop
                    transform.Translate(new Vector3(0,0,0));
                    Debug.Log("enemy to ladder");
                    for (int i = 0; i < allEnemy.Length; i++)
                    {
                        allEnemy[i].GetComponent<EnemyScript>().isAttackEnemy = true;
                    }
                }
                
                

            }

            else
            {
                if (player.transform.position.x > transform.position.x) //player on the right side
                {
                    transform.Translate(new Vector3(runningSpeed * 1.0f * Time.deltaTime, 0, 0));
                    if (faceDirection != 1.0f)
                    {
                        Flip();
                        faceDirection = 1.0f;
                    }
                }
                else
                { //player on the left side
                    transform.Translate(new Vector3(runningSpeed * -1.0f * Time.deltaTime, 0, 0));
                    if (faceDirection == 1.0f)
                    {
                        faceDirection = -1.0f;
                        Flip();
                    }
                }
            }
        }
    }

    void DetectEnemyUpDown()
    {
        float tempY = transform.position.y;
        float tempYPlayer = player.transform.position.y;

        if (Mathf.Abs(tempY - tempYPlayer) > 1.0f && tempY > tempYPlayer)
        {
            enemyMoveDown = true;
            enemyMoveUp = false;
        }
        else if (Mathf.Abs(tempY - tempYPlayer) > 1.0f && tempY < tempYPlayer)
        {
            enemyMoveDown = false;
            enemyMoveUp = true;
        }
        else
        {
            enemyMoveUp = false;
            enemyMoveDown = false;
        }
    }

    void FindNearestLadder()
    {
        GameObject[] allLadder = GameObject.FindGameObjectsWithTag("mouth");
        float result = 300;
        float positionOfObject = transform.position.x;


        for (int i = 0; i < allLadder.Length; i++)
        {
            float distance = Mathf.Abs(allLadder[i].transform.position.x - positionOfObject);
            if (distance < result)
            {

                if (enemyMoveDown && allLadder[i].GetComponent<DoorLadder>().movingUp == false && Mathf.Abs(ground.transform.position.y - allLadder[i].transform.position.y) < 0.3)
                {
                    result = distance;
                    currentLadder = allLadder[i].transform;
                }
                else if (enemyMoveUp && allLadder[i].GetComponent<DoorLadder>().movingUp && Mathf.Abs(ground.transform.position.y - allLadder[i].transform.position.y) < 0.3)
                {
                    result = distance;
                    currentLadder = allLadder[i].transform;
                }

            }
        }
    }

    void FindDoor()
    {
        GameObject[] allDoor = GameObject.FindGameObjectsWithTag("Door");
        float result = 300;
        float positionOfObject = transform.position.x;


        for (int i = 0; i < allDoor.Length; i++)
        {
            float distance = Mathf.Abs(allDoor[i].transform.position.x - positionOfObject);
            if (distance < result && Mathf.Abs(transform.position.y - allDoor[i].transform.position.y) < 0.4)
            {
                result = distance;
                currentDoor = allDoor[i].transform;

            }

            
        }
    }

    void MoveToDoor()
    {
        transform.Translate(new Vector2(normalSpeed * faceDirection * Time.deltaTime, rigidbody2D.velocity.y));
        if (faceDirection > 0 && transform.position.x > currentDoor.position.x)
        {
            faceDirection = -1.0f;
            Flip();

        }
        else if (faceDirection < 0 && transform.position.x < currentDoor.position.x)
        {
            faceDirection = 1.0f;
            Flip();

        }
    }

    void OnTriggerEnter2D(Collider2D enter)
    {
        if(enter.tag == "Player"){
            //gameover
        }

        if(enter.tag == "Ladder" || enter.tag == "mouth"){
            ladderArrive = true;
           
        }

        if ((enter.tag == "Door") && !isAttackEnemy && Application.loadedLevelName != spawnScreen)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D stay)
    {
        if ((stay.tag == "Door") && !isAttackEnemy && Application.loadedLevelName != spawnScreen)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D exit)
    {
        if(exit.tag == "Ladder" || exit.tag == "mouth"){
            ladderArrive = false;
        }
    }

    void OnLevelWasLoaded(int level)
    {

        gameObject.renderer.enabled = false;
        inActive = true;

        GameObject.FindGameObjectWithTag("MainCamera").SendMessage("EnemyNewScreen", true);


    }

    public void StopDogFindPlayer()
    {
        isAttackEnemy = false;
    }
}
