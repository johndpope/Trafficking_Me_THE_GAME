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
    public bool isMove;
    public bool isswapMove;

	void Start () {

        anim = GetComponent<Animator>();

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

        move = Input.GetAxis("Horizontal");
        move2 = Input.GetAxis("Vertical");

        if (isHide)
        {
            move = 0;
        }

        anim.SetFloat("speed", Mathf.Abs(move));

        if (isClimb)
        {
            rigidbody2D.MovePosition(rigidbody2D.position + new Vector2(0, move2 * (maxSpeed / 2) * Time.deltaTime));
        }
        else
        {
            rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
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

    
}
