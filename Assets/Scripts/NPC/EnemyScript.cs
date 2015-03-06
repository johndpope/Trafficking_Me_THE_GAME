using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{

    // Use this for initialization
    float speed = 5.0f;
    float wallLeft = 5.0f;
    float wallRight = 20.0f;
    bool onSight; // found player

    GameObject player;
    SpriteRenderer sprite;

    float faceDirection = -1.0f; //default face left
    Vector2 direction = Vector2.right;
    public bool isAttackEnemy;
    private Transform currentladder;
    private bool EnemyMoveup;
    public LayerMask layermasks;
    private Vector2 radarVector;
    private bool radarRight;
    private bool checkInsideLadder;
    //private GameObject[] allLadder;
    private bool isFindladder;
    private bool isinsideLadder;
    public LayerMask whatisLadder;
    public Transform ground;
    public float radiusGround = 0.2f;
    public float gravity = 20f;
    public bool isClimb;
    private bool enemyMoveDown;
    private bool findladderforgetback;
    private Vector3 positionBorn;
    private Transform door;
    private bool isfromanomap;
    private bool originalUp;
    private bool originalDown;
    public string ID;
    public bool inActive;
    public string spawnScreen;
    private Transform currentDoor;
    private bool sameYAxis; //is enemy in the same y axis as door
    private bool goToDoorFromLadder;

    private bool doorladderUp;
    private bool doorladderDown;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        sprite = GetComponent<SpriteRenderer>();
        radarVector = new Vector2(-1, 1);
        positionBorn = gameObject.transform.position;
        GameObject[] friend = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < friend.Length; i++)
        {
            Physics2D.IgnoreCollision(gameObject.collider2D, friend[i].collider2D);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (inActive)
        {
            //do nothing
            Physics2D.IgnoreCollision(player.collider2D, collider2D);
            
        }
        else
        {
            //when not find player and enemy not spawn on this scene
            if (!isAttackEnemy && spawnScreen != Application.loadedLevelName)
            {
                FindDoor();
                if (!isClimb)
                {
                    transform.Translate(new Vector2(speed * faceDirection * Time.deltaTime, rigidbody2D.velocity.y));
                }
                if (sameYAxis) //go to door
                {
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
                else //go to ladder instead of door
                {
                    if(currentladder != null){
                        //Debug.Log(currentladder.position.x);
                        if (faceDirection > 0 && transform.position.x > currentladder.position.x)
                        {
                            faceDirection = -1.0f;
                            Flip();

                        }
                        else if (faceDirection < 0 && transform.position.x < currentladder.position.x)
                        {
                            faceDirection = 1.0f;
                            Flip();

                        }
                    }
                    else
                    {
                        FindLadder();
                    }
                }

            }

            if (!isAttackEnemy)
            {
                Physics2D.IgnoreCollision(player.collider2D, collider2D);
            }
            else
            {
                Physics2D.IgnoreCollision(player.collider2D, collider2D, false);
                DontDestroyOnLoad(gameObject);
            }

            isinsideLadder = Physics2D.OverlapCircle(ground.position, radiusGround, whatisLadder);

            direction = new Vector2(faceDirection, 0);

            if (!onSight) //not find player
            {
                //find ladder
                if (findladderforgetback && spawnScreen == Application.loadedLevelName)
                {
                    FindLadder();
                    findladderforgetback = false;
                }
                float temp = 1;
                if (originalDown && spawnScreen == Application.loadedLevelName)
                {
                    temp = -1;
                }
                else if (originalUp && spawnScreen == Application.loadedLevelName)
                {
                    temp = 1;
                }
                else if(doorladderDown)
                {
                    temp = -1;
                }
                if (isClimb)
                {
                    checkInsideLadder = true;
                    rigidbody2D.MovePosition(rigidbody2D.position + new Vector2(0, temp * speed * Time.deltaTime));

                }

                //script when enemy spawn on the current scene
                if (spawnScreen == Application.loadedLevelName)
                {
                    transform.Translate(new Vector2(speed * faceDirection * Time.deltaTime, rigidbody2D.velocity.y));
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
            DetectEnemy();
            MoveToPlayer();
            DetectEnemyUp();
            DetectEnemyDown();
            detectOriginal();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //DestroyObject(player);
            onSight = false;
            
        }
    }

    void MoveToPlayer()
    {
        if (isinsideLadder)
        {
            rigidbody2D.gravityScale = 0;
            rigidbody2D.isKinematic = true;
        }
        else
        {
            rigidbody2D.gravityScale = 1;
            rigidbody2D.isKinematic = false;
            isClimb = false;

        }
        if (isAttackEnemy) //when enemy find you
        {
            onSight = true;

            if (EnemyMoveup || enemyMoveDown)
            {

                float temp = 1;
                if (enemyMoveDown)
                {
                    temp = -1;
                }
                else
                {
                    temp = 1;
                }
                if (!isFindladder && currentladder == null)
                {
                    FindLadder();
                    isFindladder = true;
                }
                if (isClimb)
                {
                    checkInsideLadder = true;
                    rigidbody2D.MovePosition(rigidbody2D.position + new Vector2(0, temp * speed * Time.deltaTime));

                }
                if (!checkInsideLadder)
                {
                    if (currentladder == null) {
                        FindLadder();
                    }
                    if (currentladder.position.x > transform.position.x) //player on the right side
                    {
                        transform.Translate(new Vector3(speed * 1.0f * Time.deltaTime, 0, 0));
                        if (faceDirection != 1.0f)
                        {
                            Flip();
                            faceDirection = 1.0f;
                        }
                    }
                    else
                    { //player on the left side
                        transform.Translate(new Vector3(speed * -1.0f * Time.deltaTime, 0, 0));
                        if (faceDirection == 1.0f)
                        {
                            faceDirection = -1.0f;
                            Flip();
                        }
                    }
                }
            }
            else if (player.transform.position.x > transform.position.x) //player on the right side
            {
                transform.Translate(new Vector3(speed * 1.0f * Time.deltaTime, 0, 0));
                if (faceDirection != 1.0f)
                {
                    Flip();
                    faceDirection = 1.0f;
                }
            }
            else
            { //player on the left side
                transform.Translate(new Vector3(speed * -1.0f * Time.deltaTime, 0, 0));
                if (faceDirection == 1.0f)
                {
                    faceDirection = -1.0f;
                    Flip();
                }
            }
        }
        else
        {
            onSight = false;
        }
    }

    void Flip()
    {

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    void DetectEnemy()
    {
        RaycastHit2D hitSomething = Physics2D.Raycast(transform.position, direction, 8.0f);
        if (hitSomething.collider != null)
        {
            //Debug.Log(hitSomething.collider.gameObject.tag);
            if (hitSomething.collider.gameObject.tag == "Player" && player.renderer.enabled)
            {
                GameObject.FindGameObjectWithTag("MainCamera").SendMessage("SetAlert", true);
                
                if (!isClimb)
                {
                    
                    isAttackEnemy = true;
                    EnemyMoveup = false;
                    checkInsideLadder = false;
                    currentladder = null;
                    enemyMoveDown = false;
                    isFindladder = false;
                }

            }

        }
    }
    void DetectEnemyUp()
    {
        if (radarRight)
        {
            radarVector.x += 1;
            if (radarVector.x >= 5)
            {
                radarRight = false;
            }
        }
        else
        {
            radarVector.x -= 1;
            if (radarVector.x <= -5)
            {
                radarRight = true;
            }
        }
        RaycastHit2D hitSomething = Physics2D.Raycast(transform.position, new Vector2(radarVector.x / 10, 1), 30.0f, layermasks);
        
        if (hitSomething.collider != null)
        {
            
            if (hitSomething.collider.gameObject.tag == "Player")
            {

                EnemyMoveup = true;
            }

        }
    }
    void OnTriggerEnter2D(Collider2D e)
    {
        if (e.tag == "mouth")
        {
            DoorLadder temp = e.GetComponent<DoorLadder>();
            if (temp.movingUp && enemyMoveDown && !EnemyMoveup)
            {

                isClimb = false;
                //checkInsideLadder = false;
                enemyMoveDown = false;
                EnemyMoveup = false;
                isFindladder = false;
                //currentladder = null;
            }
            else if (!temp.movingUp && !enemyMoveDown && EnemyMoveup)
            {
                currentladder = null;
            }
            if (temp.movingUp && !isAttackEnemy && isClimb)
            {
                Debug.Log("stop climbing");
                isClimb = false;
                currentladder = null;
                rigidbody2D.gravityScale = 0.34f;
                rigidbody2D.isKinematic = false;
            }

            //go to door case
            /*else if(goToDoorFromLadder == true){
                currentladder = null;
            }*/
        }

        if((e.tag == "Door") && !isAttackEnemy && Application.loadedLevelName != spawnScreen){
            Destroy(gameObject);
        }

        
    }
    void OnTriggerStay2D(Collider2D e)
    {
        

        if ((e.tag == "Ladder" || e.tag == "mouth") && isinsideLadder)
        {
            
            
            if ((enemyMoveDown || EnemyMoveup) && currentladder != null)
            {
                
                if ((transform.position.x - currentladder.position.x) < 0.3)
                {
                    isClimb = true;

                }
                
            }
            else if(goToDoorFromLadder && currentladder != null){
                if ((transform.position.x - currentladder.position.x) < 0.3)
                {
                    isClimb = true;

                }
            }

            // Debug.Log("ladder!!!");
            isFindladder = false;
        }
    }
    void OnTriggerExit2D(Collider2D e)
    {

        if (e.tag == "Ladder")
        {
            checkInsideLadder = false;
            EnemyMoveup = false;
            enemyMoveDown = false;
            rigidbody2D.gravityScale = 20;
            rigidbody2D.isKinematic = true;
        }
    }



    void FindLadder()
    {
        GameObject[] allLadder = GameObject.FindGameObjectsWithTag("mouth");
        float result = 300;
        float positionOfOject;
        /*if (enemyMoveDown && isAttackEnemy)
        {
            positionOfOject = transform.position.x;
        }
        else if (EnemyMoveup && isAttackEnemy)
        {
            positionOfOject = player.transform.position.x;
        }
        else
        {
            positionOfOject = player.transform.position.x;
        }*/
        positionOfOject = player.transform.position.x;
        for (int i = 0; i < allLadder.Length; i++)
        {
            float distance = Mathf.Abs(allLadder[i].transform.position.x - positionOfOject);
            if (distance < result)
            {
                if (enemyMoveDown && allLadder[i].GetComponent<DoorLadder>().movingUp == false && Mathf.Abs(ground.transform.position.y - allLadder[i].transform.position.y) < 0.3)
                {
                    result = distance;
                    currentladder = allLadder[i].transform;
                }
                else if (EnemyMoveup && allLadder[i].GetComponent<DoorLadder>().movingUp && Mathf.Abs(ground.transform.position.y - allLadder[i].transform.position.y) < 0.3)
                {
                    result = distance;
                    currentladder = allLadder[i].transform;
                }
            }

            
        }
    }
    void DetectEnemyDown()
    {
        RaycastHit2D hitSomething = Physics2D.Raycast(transform.position, new Vector2(radarVector.x / 10, -1), 30.0f, layermasks);

        if (hitSomething.collider != null)
        {

            // Debug.Log(hitSomething.collider.tag );
            if (hitSomething.collider.gameObject.tag == "Player")
            {
                enemyMoveDown = true;
            }
            else
            {
                enemyMoveDown = false;
            }

        }
    }

    //search born point is down or up
    public void detectOriginal()
    {
        float tempY = transform.position.y;
        float tempYOrigin = positionBorn.y;
        //Debug.Log(Mathf.Abs(tempY - tempYOrigin));
        if (Mathf.Abs(tempY - tempYOrigin) > 0.3f && tempY > tempYOrigin)
        {
            originalDown = true;
            originalUp = false;
        }
        else if (Mathf.Abs(tempY - tempYOrigin) > 0.3f && tempY < tempYOrigin)
        {
            originalDown = false;
            originalUp = true;
        }
        else
        {
            originalUp = false;
            originalDown = false;
        }
    }
    public void stopEnemyfindPlayer()
    {
        isAttackEnemy = false;
    }


    void OnLevelWasLoaded(int level)
    {
        gameObject.renderer.enabled = false;
        inActive = true;
        GameObject.FindGameObjectWithTag("MainCamera").SendMessage("EnemyNewScreen", true);

        EnemyMoveup = false;
        enemyMoveDown = false;
        if (isAttackEnemy == true)
        {
            GameObject[] tempList = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < tempList.Length; i++)
            {
                if (tempList[i].GetComponent<EnemyScript>().isAttackEnemy == false && tempList[i].GetComponent<EnemyScript>().ID == ID)
                {
                    Destroy(tempList[i]);
                    break;
                }
            }
        }

    }

    //when enemy cannot find player and find door to destroy themself
    void FindDoor()
    {
        GameObject[] allDoor = GameObject.FindGameObjectsWithTag("Door");
        float result = 300;
        float positionOfObject = transform.position.x;


        for (int i = 0; i < allDoor.Length; i++)
        {
            float distance = Mathf.Abs(allDoor[i].transform.position.x - positionOfObject);
            if (distance < result)
            {
                result = distance;
                currentDoor = allDoor[i].transform;

            }
        }

        doorladderDown = false;
        doorladderUp = false;
        

        if (currentDoor.position.y + 0.4 > transform.position.y && transform.position.y + 0.4 > currentDoor.position.y)
        { //check enemy is in same y axis as door
            Debug.Log("go to door");
            goToDoorFromLadder = false;
            sameYAxis = true;
        }
        else
        {
            
            //Debug.Log(currentDoor.position.y + " " + transform.position.y);
            if(currentDoor.position.y + 0.4 < transform.position.y){
                doorladderDown = true;
            }
            else
            {
                doorladderUp = true;
            }

            Debug.Log("find ladder!!!");
            sameYAxis = false;
            goToDoorFromLadder = true;
            FindLadderToDoor();

        }

    }

    //when y axis of the enemy and door isn't the same, so find ladder first
    void FindLadderToDoor()
    {
        /*GameObject[] allLadder = GameObject.FindGameObjectsWithTag("Ladder");
        float result = 300;
        float positionOfObjectX = transform.position.x;
        float positionOfObjectY = transform.position.y;

        for (int i = 0; i < allLadder.Length; i++)
        {
            float distance = Mathf.Abs(allLadder[i].transform.position.x - positionOfObjectX);
            //Debug.Log(allLadder[i].transform.position.y + " " + transform.position.y);
            if (distance < result && Mathf.Abs(transform.position.y - allLadder[i].transform.position.y) < 4)
            {
                result = distance;
                currentladder = allLadder[i].transform;

            }
        }*/

        GameObject[] allLadder = GameObject.FindGameObjectsWithTag("mouth");
        float result = 300;
        float positionOfObjectX = transform.position.x;
        //float positionOfObjectY = transform.position.y;
        for (int i = 0; i < allLadder.Length; i++)
        {
            float distance = Mathf.Abs(allLadder[i].transform.position.x - positionOfObjectX);
            if (distance < result)
            {
                if (doorladderDown && allLadder[i].GetComponent<DoorLadder>().movingUp == false && Mathf.Abs(ground.transform.position.y - allLadder[i].transform.position.y) < 0.3)
                {
                    result = distance;
                    currentladder = allLadder[i].transform;
                }
                else if (doorladderUp && allLadder[i].GetComponent<DoorLadder>().movingUp && Mathf.Abs(ground.transform.position.y - allLadder[i].transform.position.y) < 0.3)
                {
                    result = distance;
                    currentladder = allLadder[i].transform;
                }
                
            }
        }

    }
}