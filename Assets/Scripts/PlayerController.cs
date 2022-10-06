using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    private Rigidbody2D rb;         //The Rigidbody 2D attached to the Player
    private SpriteRenderer sr;      //The Sprite Renderer attached to the Player
    private Animator anim;          //The Animator attached to the Player

    private float inputX;           //States if the player is moving left or right

    public float moveSpeed;         //Determines how fast the player moves
    public float jumpForce;         //Determines how high the player jumps
    public float knockbackForce;    //Determines how far the player is knocked back
    public float knockbackLength, knockbackCounter;

    public bool isControllable;     //States whether the player can move    


    public bool isGrounded;         //States if the Player is on the ground or not
    public Transform groundCheck;   //This must be touching ground for the player to jump
    public LayerMask whatIsGround;  //States what is considered ground

    public string areaComingFrom;   //When switching scenes, states the scene the player is coming from

    public PlayerInput playerInput;

    public DialogActivator currentDialog;


    private void Awake()
    {
        //if (instance == null)
        //{
            instance = this;
        //}
        //else Destroy(gameObject);
        //DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (knockbackCounter <= 0)
        {
            if(isControllable)
            {
                rb.velocity = new Vector2(inputX * moveSpeed, rb.velocity.y); 
            }
            
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, whatIsGround); // Determines if the Player is on the Ground
            
            //Flips the way the Player Sprite is facing
            if (rb.velocity.x < 0)
            {
                sr.flipX = true;
            }
            else if (rb.velocity.x > 0)
            {
                sr.flipX = false;
            }
        }
        else
        {
            knockbackCounter -= Time.deltaTime;
            if (!sr.flipX)
            {
                rb.velocity = new Vector2(-knockbackForce, rb.velocity.y);
            }
            else rb.velocity = new Vector2(knockbackForce, rb.velocity.y);

            

        }

        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("isMoving", Mathf.Abs(rb.velocity.x));
        anim.SetFloat("isFalling", rb.velocity.y);


    }


    public void Knockback()
    {
        knockbackCounter = knockbackLength;
        rb.velocity = new Vector2(0f, knockbackForce);
        isControllable = false;
        anim.SetTrigger("Death");
    }




    public void Move(InputAction.CallbackContext context)
    {
        inputX = context.ReadValue<Vector2>().x;
    }
    
    public void Jump(InputAction.CallbackContext context)
    {
        if (isGrounded && context.performed)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    public void ActivateUI(InputAction.CallbackContext context)
    {
        if (currentDialog && context.performed)
        {
            Debug.Log("Switching map to UI");
            playerInput.SwitchCurrentActionMap("UI");
            DialogManager.instance.ShowDialog(currentDialog.lines, currentDialog.isPerson);
            //playerInput.SwitchCurrentActionMap("UI");
        }
    }



    public void Submit(InputAction.CallbackContext context)
    {
        //Debug.Log("Submit worked");
        //DialogManager.instance.TestLog();
        DialogManager.instance.dialogForward(context);
    }
}
