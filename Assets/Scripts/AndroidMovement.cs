using UnityEngine;

public class AndroidMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    private float horizontalMove;
    private bool MoveRight;
    private bool MoveLeft;
    private Rigidbody2D rb;
    private Animator anim;
    private bool isGrounded;
    private bool hasJumped;
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        MoveLeft = false;
        MoveRight = false;
        
    }

    public void pointerDownLeft()
    {
        MoveLeft = true;
    }
    public void pointerUpLeft()
    {
        MoveLeft = false;
    }
    
    public void pointerDownRight()
    {
        MoveRight = true;
    }

    public void pointerUpRight()
    {
        MoveRight = false;
    }

  

  

 

    

   

    void Movement()
    {
        if (MoveLeft)
        {
            horizontalMove = -speed;
        }

        else if (MoveRight)
        {
            horizontalMove = speed;
        }

        else
        {
            horizontalMove = 0;
        }

        if (horizontalMove > 0.01f)
        {
            transform.localScale = new Vector3(3, 3, 3);
        }

        else if (horizontalMove < -0.01f)
        {
            transform.localScale = new Vector3(-3, 3, 3);
        }

        anim.SetBool("Run", horizontalMove != 0);
    }

  public void Jumping()
    {
        if (isGrounded)
        {
            
            rb.velocity = new Vector2(rb.velocity.x, speed);
            hasJumped = true;



        }

        else if (hasJumped)
        {
            
            rb.velocity = new Vector2(rb.velocity.x, speed);
            hasJumped = false;




        }

        anim.SetTrigger("jump");
    }

      
    
    public void Update()
    {
        Movement();
        
        float horizontalMove = Input.GetAxis("Horizontal");

        

       

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (horizontalMove, rb.velocity.y);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

}
