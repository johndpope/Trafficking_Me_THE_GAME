using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{

    // Use this for initialization
    float speed = 0;
    float speedWalk = 2.5f;
    float speedRun = 2.5f;
    public float wallLeft;
    public float wallRight;
    public bool onSight; // found player

    GameObject player;
    SpriteRenderer sprite;

    float faceDirection = -1.0f; //default face left
    Vector2 direction = Vector2.right;
    public bool isAttackEnemy;
    public Transform currentladder;
    public bool EnemyMoveup;
    public LayerMask layermasks;
    private bool radarRight;
    private bool checkInsideLadder;
    //private GameObject[] allLadder;
    private bool isFindladder;
    public bool isinsideLadder;
    public LayerMask whatisLadder;
    public Transform ground;
    public float radiusGround = 0.2f;
    public float gravity = 20f;
    public bool isClimb;
    public bool enemyMoveDown;
    public bool findladderforgetback;
    public Vector3 positionBorn;
    private Transform door;
    private bool isfromanomap;
    public bool originalUp;
    public bool originalDown;
    public string ID;
    public bool inActive;
    public string spawnScreen;
    public Transform currentDoor;
    private bool sameYAxis; //is enemy in the same y axis as door
    private bool goToDoorFromLadder;

    public bool doorladderUp;
    public bool doorladderDown;
    private Animator anim;
    private CharacterController running;
    public float maximumHearing;
    private GameController system;

    private Vector3 tempPositionBorn;
    private bool ischecking;
    private bool isWorry;

    private bool soundOn;
    private Vector3 originalPositionBorn;
    private IEnumerator stopWalking;
    public bool isWalking;
    private float directionclimb = 1;
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        running = player.GetComponent<CharacterController>();
        sprite = GetComponent<SpriteRenderer>();
        positionBorn = gameObject.transform.position;
        wallLeft = positionBorn.x - 5;
        wallRight = positionBorn.x + 5;
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        GameObject[] friend = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < friend.Length; i++)
        {
            Physics2D.IgnoreCollision(gameObject.collider2D, friend[i].collider2D);
        }
        GameObject[] allDog = GameObject.FindGameObjectsWithTag("Dog");
        for (int i = 0; i < allDog.Length; i++)
        {
            Physics2D.IgnoreCollision(gameObject.collider2D, allDog[i].collider2D);
        }

        originalPositionBorn = positionBorn;
        isWalking = true;
        stopWalking = Stopwalking();
    }

    // Update is called once per frame
    void Update()
    {

        if (inActive)
        {
            //do nothing
            Physics2D.IgnoreCollision(player.collider2D, collider2D);

        }

        if (Application.isLoadingLevel && isAttackEnemy)
        {
            //Debug.Log("don't destory");
            DontDestroyOnLoad(gameObject);
            rigidbody2D.velocity = Vector2.zero;
        }
        else if (Application.isLoadingLevel && !isAttackEnemy)
        {
            //Debug.Log("destroy");
            Destroy(gameObject);
        }
        if (!inActive)
        {
            detectPlayerwithSound();
            changeCurrentBornposition();
        }
    }
    void FixedUpdate()
    {
        
        if (inActive)
        {
            //do nothing
            Physics2D.IgnoreCollision(player.collider2D, collider2D);
            
        }
        else
        {
            //animation part
            if (isClimb)
            {
                anim.SetBool("climbing", true);
            }
            else
            {
                anim.SetBool("climbing", false);
            }

            if (isAttackEnemy)
            {
                speed = speedRun + speedWalk;
            }
            else
            {
                speed = speedWalk;
            }

            if(soundOn){
                ChangeEnemyMovement();
            }

            //when not find player and enemy not spawn on this scene
            if (!isAttackEnemy && spawnScreen != Application.loadedLevelName)
            {
                FindDoor();
                if (!isClimb)
                {
                    transform.Translate(new Vector2(speed * faceDirection * Time.deltaTime, 0));
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

            }

            isinsideLadder = Physics2D.OverlapCircle(ground.position, radiusGround, whatisLadder);


            if (!onSight) //not find player
            {
                if (currentladder == null)
                {
                    findladderforgetback = false;
                }
                //find ladder
                if (!findladderforgetback && spawnScreen == Application.loadedLevelName)
                {
                    FindLadder();
                    findladderforgetback = true;
                }
                if (originalDown && spawnScreen == Application.loadedLevelName)
                {
                    directionclimb = -1;
                }
                else if (originalUp && spawnScreen == Application.loadedLevelName)
                {
                    directionclimb = 1;
                }
                else if (doorladderDown && spawnScreen != Application.loadedLevelName)
                {
                    directionclimb = -1;
                }
                else if (doorladderUp && spawnScreen != Application.loadedLevelName)
                {
                    directionclimb = 1;
                }
                if (isClimb)
                {
                    checkInsideLadder = true;
                    transform.Translate(new Vector2(0, directionclimb * speed * Time.deltaTime)); 
                }

                //script when enemy spawn on the current scene
                if (spawnScreen == Application.loadedLevelName && originalUp == false && originalDown == false)
                {
                    if (isWalking)
                    {
                        transform.Translate(new Vector2(speed * faceDirection * Time.deltaTime, rigidbody2D.velocity.y));
                    }
                    
                    if (faceDirection > 0 && transform.position.x > wallRight)
                    {
                        StopCoroutine(stopWalking);
                        stopWalking = Stopwalking();
                        StartCoroutine(stopWalking);
                        faceDirection = -1.0f;
                        Flip();

                    }
                    else if (faceDirection < 0 && transform.position.x < wallLeft)
                    {
                        StopCoroutine(stopWalking);
                        stopWalking = Stopwalking();
                        StartCoroutine(stopWalking);
                        faceDirection = 1.0f;
                        Flip();

                    }
                }
                else if (spawnScreen == Application.loadedLevelName && currentladder != null && !isClimb)
                {
                    transform.Translate(new Vector2(speed * faceDirection * Time.deltaTime, rigidbody2D.velocity.y));
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

            }
            DetectEnemy();
            MoveToPlayer();
            DetectEnemyUpDown();
            detectOriginal();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //DestroyObject(player);
            onSight = false;
            col.gameObject.renderer.enabled = true;
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

                
                if (enemyMoveDown)
                {
                    directionclimb = -1;
                }
                else
                {
                    directionclimb = 1;
                }
                if (!isFindladder && currentladder == null)
                {
                    FindLadder();
                    isFindladder = true;
                }
                if (isClimb)
                {
                    checkInsideLadder = true;
                    rigidbody2D.MovePosition(rigidbody2D.position + new Vector2(0, directionclimb * speed * Time.deltaTime));

                }
                else
                {
                    checkInsideLadder = false;
                }
                if (!checkInsideLadder)
                {
                    if (currentladder == null) {
                        FindLadder();
                    }
                    if (currentladder !=null && currentladder.position.x > transform.position.x) //player on the right side
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
        if (faceDirection == 1)
        {
            direction = Vector2.right;
        }
        else
        {
            direction = new Vector2(-1, 0);
        }
        RaycastHit2D hitSomething = Physics2D.Raycast(transform.position, direction, 8.0f, layermasks);
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
                    findladderforgetback = false;
                    isWalking = true;
                    anim.speed = 1;
                    StopCoroutine(stopWalking);
                }

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
                currentladder = null;
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
            if ((!temp.movingUp || temp.movingUp) && (originalDown || !originalUp) && (!originalDown || originalUp))
            {
                findladderforgetback = false;
                
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
            
            if (isAttackEnemy && (enemyMoveDown || EnemyMoveup) && currentladder != null)
            {
              
                if (Mathf.Abs(transform.position.x - currentladder.position.x) < 0.1)
                {
                    isClimb = true;

                }
                
            }
            else if(goToDoorFromLadder && currentladder != null){
                if (Mathf.Abs(transform.position.x - currentladder.position.x) < 0.2)
                {
                    isClimb = true;

                }
            }

            if(!isAttackEnemy && (originalDown || originalUp) && isinsideLadder){
                if (currentladder != null && Mathf.Abs(transform.position.x - currentladder.position.x) < 0.2)
                {
                    isClimb = true;

                }
                /*else
                {
                    isClimb = true;
                }*/
            }
           
            isFindladder = false;
        }

        if ((e.tag == "Door") && !isAttackEnemy && Application.loadedLevelName != spawnScreen)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D e)
    {

       if (e.tag == "Ladder")
        {
            checkInsideLadder = false;
            EnemyMoveup = false;
            enemyMoveDown = false;
            originalDown = false;
            originalUp = false;
            isClimb = false;
            rigidbody2D.gravityScale = 20;
            rigidbody2D.isKinematic = true;
            isFindladder = false;
        }
    }



    void FindLadder()
    {
        GameObject[] allLadder = GameObject.FindGameObjectsWithTag("mouth");
        float result = 300;
        float positionOfOject;
        
        if (isAttackEnemy)
        {
            positionOfOject = player.transform.position.x;
        }
        else
        {
            positionOfOject = positionBorn.x;
        }
        
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
    void DetectEnemyUpDown()
    {
        float tempY = transform.position.y;
        float tempYPlayer = player.transform.position.y;
        //Debug.Log(Mathf.Abs(tempY - tempYOrigin));
        if (Mathf.Abs(tempY - tempYPlayer) > 0.3f && tempY > tempYPlayer)
        {
            enemyMoveDown = true;
            EnemyMoveup = false;
        }
        else if (Mathf.Abs(tempY - tempYPlayer) > 0.3f && tempY < tempYPlayer)
        {
            enemyMoveDown = false;
            EnemyMoveup = true;
        }
        else
        {
            EnemyMoveup = false;
            enemyMoveDown = false;
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

    void detectPlayerwithSound()
    {
        float length = Vector2.Distance(gameObject.transform.position, player.transform.position);
        if (!isAttackEnemy && (running.move != 0 || running.move2 != 0) && length <= maximumHearing)
        {
            float dangerousValue = 0;
            float muli = 0;

            if (running.getRun())
            {
                muli = 2;
            }
            else
            {
                muli = 1;
            }
            dangerousValue = maximumHearing - length;
            system.IncreaseWarmningLevel(dangerousValue * muli);
        }

    }
    public void changeCurrentBornposition()
    {
        if (system.getWarningLevel() > 60 && !ischecking && !isAttackEnemy)
        {
            tempPositionBorn = positionBorn;
            if (player.GetComponent<CharacterController>().isClimb)
            {
                Vector2 tempPosition = new Vector2(player.transform.position.x, gameObject.transform.position.y);
                positionBorn = tempPosition;
            }
            else
            {
                positionBorn = player.transform.position;
            }
            wallLeft = positionBorn.x - 5;
            wallRight = positionBorn.x + 5;
            ischecking = true;
            isWorry = true;
            StartCoroutine(checking());

            detectOriginal();
            if (originalUp || originalDown)
            {
                FindLadder();
            }


        }
        else if (system.getWarningLevel() < 60 && !ischecking && isWorry)
        {
            Debug.Log("checkingtemp");
            isWorry = false;
            positionBorn = tempPositionBorn;
            wallLeft = positionBorn.x - 5;
            wallRight = positionBorn.x + 5;

            detectOriginal();
            if (originalUp || originalDown)
            {
                FindLadder();
            }
        }
    }

    //make enemy move stop searching when heard the sound
    public void ChangeEnemyMovement()
    {
        
        if (isWorry && !isAttackEnemy)
        {

            ischecking = false;
            system.setWarningLevel(0);
            system.setWarning(false);

            tempPositionBorn = originalPositionBorn;

            soundOn = false;
        }
        else
        {
            soundOn = false;
        }
    }

    public IEnumerator checking()
    {
        yield return new WaitForSeconds(5);
        ischecking = false;
    }

    public void SetSoundAttract(bool n)
    {
        soundOn = n;
    }
    public IEnumerator Stopwalking()
    {
        isWalking = false;
        anim.speed = 0;
        yield return new WaitForSeconds(3);
        anim.speed = 1;
        isWalking = true;
    }
    
}