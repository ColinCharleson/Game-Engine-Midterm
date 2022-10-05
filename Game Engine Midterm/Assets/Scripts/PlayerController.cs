using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    
    //Components
    Rigidbody rb;

    //Movement Variables
    public float jumpForce;
    public float speed;
    public bool isGrounded;

    //Ground Check
    public Transform groundCheck;
    public float groundDistance;
    public LayerMask whatIsGround;

    //Player Stats
    public int health = 3;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, whatIsGround);

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }

        if(this.transform.position.y <= -5)
		{
            GameManager.instance.GameReset();
		}
    }

}
