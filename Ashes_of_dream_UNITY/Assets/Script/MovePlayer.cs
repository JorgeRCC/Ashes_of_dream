using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour

{
   public GameManager GameManager;
    int trampasLayer; //ID de la capa trampas

    private Rigidbody2D rb2D;

    [Header("Movement")]

    private float horizontalMovement = 0f;

    [SerializeField] private float moveSpeed;

    [Range(0, 0.3f)] [SerializeField] private float motionSmoothing;

    private Vector3 speed = Vector3.zero;

    private bool lookingRight = true;

    [Header("Jump")]

    [SerializeField] private float airMovementSpeed;

    [SerializeField] private float jumpingForce;

    [SerializeField] private LayerMask floorDetector;

    [SerializeField] private Transform floorController;

    [SerializeField] private Vector3 boxDimensions;

    [SerializeField] private bool onTheFloor;

    private bool jump = false;

    [Header("Animation")]

    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        trampasLayer = LayerMask.NameToLayer("Trampas");  //ID de la capa trampas

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == trampasLayer)
        {
            {
			    GameManager.Instance.PerderVida();
		
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Mathf.Abs(horizontalMovement));
        animator.SetFloat("velocityY", rb2D.velocity.y);

        if (onTheFloor == true)
        {
            horizontalMovement = Input.GetAxisRaw("Horizontal") * moveSpeed;
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (onTheFloor == false)
        {
            horizontalMovement = Input.GetAxisRaw("Horizontal") * airMovementSpeed;
        }
    }

    private void FixedUpdate()
    {
        onTheFloor = Physics2D.OverlapBox(floorController.position, boxDimensions, 0f, floorDetector);
        animator.SetBool("onTheFloor", onTheFloor);

        Move(horizontalMovement * Time.fixedDeltaTime, jump);

        jump = false;
    }

    private void Move(float move, bool jumping)
    {
        Vector3 targetSpeed = new Vector2(move, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, targetSpeed, ref speed, motionSmoothing);

        if (move > 0 && !lookingRight)
        {
            Turn();
        }
        else if (move < 0 && lookingRight)
        {
            Turn();
        }

        if (onTheFloor && jump)
        {
            onTheFloor = false;
            rb2D.AddForce(new Vector2(0f, jumpingForce));
        }


    }

    private void Turn()
    {
        lookingRight = !lookingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(floorController.position, boxDimensions);
    }
}
