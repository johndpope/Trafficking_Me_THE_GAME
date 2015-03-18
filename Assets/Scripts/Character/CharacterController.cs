using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	// Use this for initialization
    public float maxSpeed = 10.0f;
    bool facingRight = false;
    public Animator anim;
    public bool grounded = false;
    public Transform groundCheck;
    public Transform headCheck;
    public float groundRadius = 0.2f;
    float headRadius = 0.2f;
    public LayerMask whatIsHead;
    public LayerMask whatIsLadder;
    public bool detectdown;
    public bool isClimb;
    public float gravity = 20;
    public float move;
    public float move2;
    public bool isHide;
    private bool climbAnime;

    //player stat part
    public bool isMove;
    private int swapMove = -1;
    public bool isswapMove;

    public bool isRun;
    public float speedRun;
    //joystick part
    Joystick moveJoystick;
    float defaultXPosition = 0.0f;
    float defaultYPosition = 0.0f;
	void Start () {
        isMove = true;
        anim = GetComponent<Animator>();
        //moveJoystick = GameObject.FindGameObjectWithTag("Joystick").GetComponent<Joystick>();
	}

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

	// Update is called once per frame
	void FixedUpdate () {
        //Debug.Log(currentMap + " " + previousMap);

        detectdown = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsLadder);
        if (isClimb)
        {

            rigidbody2D.gravityScale = 0;
        }
        if (detectdown)
        {
            rigidbody2D.gravityScale = 0;
            rigidbody2D.isKinematic = true;
        }
        else
        {

            rigidbody2D.gravityScale = gravity;
            rigidbody2D.isKinematic = false;
            isClimb = false;

        }

        //joystick move
        //horizontal movement
        /*if ((moveJoystick.position.x > defaultXPosition || moveJoystick.position.x < defaultXPosition)
                && Mathf.Abs(moveJoystick.position.x) >= Mathf.Abs(moveJoystick.position.y))
        {
            move = moveJoystick.position.x - defaultXPosition;
        }
        //vertical movement
        else if ((moveJoystick.position.y > defaultYPosition || moveJoystick.position.y < defaultYPosition)
                && Mathf.Abs(moveJoystick.position.y) > Mathf.Abs(moveJoystick.position.x))
        {

            move2 = moveJoystick.position.y - defaultYPosition;
        }
        else
        {
            move = 0;
            move2 = 0;
        }*/

        //keyboard move
        move = Input.GetAxis("Horizontal");
        move2 = Input.GetAxis("Vertical");

        if (isHide)
        {
            move = 0;
        }

        //when bravery stat is 0, move inverse
        if (isswapMove)
        {
            move *= swapMove;
            Debug.Log("move inverse na ja!!!");
        }

        if (!isMove)
        {
            move = 0;
        }


        /*if(!climbAnime){
            move2 = 0;
        }*/

        anim.SetFloat("speed", Mathf.Abs(move));

        float speedMove;
        if (isRun)
        {
            speedMove = maxSpeed + speedRun;
        }
        else
        {
            speedMove = maxSpeed;
        }

        if (isClimb)
        {
            rigidbody2D.MovePosition(rigidbody2D.position + new Vector2(0, move2 * (speedMove / 2) * Time.deltaTime));
            if (move2 == 0)
            {
                anim.speed = 0;
            }
            else
            {
                anim.speed = 1;
            }
            anim.SetFloat("speed2", 1);
            
        }
        else
        {
            rigidbody2D.velocity = new Vector2(move * speedMove, rigidbody2D.velocity.y);
            anim.SetFloat("speed2", Mathf.Abs(0));
        }

        

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
	}

    public void IsHiding(bool n)
    {
        isHide = n;
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "mouth" || col.tag == "Ladder"){
            climbAnime = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "mouth" || col.tag == "Ladder")
        {
            climbAnime = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "mouth" || col.tag == "Ladder")
        {
            climbAnime = false;
        }
    }

    public void changeRun()
    {
        isRun = !isRun;
    }
    public bool getRun()
    {
        return isRun;
    }
}
