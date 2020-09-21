using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
<<<<<<< Updated upstream
#region Variables

    public Animator animator;
=======
#region Varaibles
>>>>>>> Stashed changes

[Header("Input Settings:")]
public float movementSpeed;
public float energy;
public float decreaseSpeed;

[Space]
[Header("Character statistics:")]
public Vector2 movementDirection;

[Space]
[Header("References:")]
private Rigidbody2D rb;
public Animator animator;

#endregion

#region Methods
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ProcessInput();

        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        movementDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        bool isMovingHorizontal = Mathf.Abs(movementDirection.x) > 0.5f;
        bool isMovingvertical = Mathf.Abs(movementDirection.y) > 0.5f;
        bool wasMovingVertical = false;

        Vector2 lastMove;
        

        if(isMovingHorizontal && isMovingvertical)
        {
            if(wasMovingVertical)
            {
                rb.velocity = new Vector2(movementDirection.x * movementSpeed * Time.deltaTime, 0);
                lastMove = new Vector2( movementDirection.x, 0f);
            }
            else
            {
                rb.velocity = new Vector2(0, movementDirection.y * movementSpeed * Time.deltaTime);
                lastMove = new Vector2(0f, movementDirection.y);
            }
        }
        else if(isMovingHorizontal)
        {
            rb.velocity = new Vector2(movementDirection.x * movementSpeed * Time.deltaTime, 0);
            wasMovingVertical = false;
            lastMove = new Vector2( movementDirection.x, 0f);
        }
        else if(isMovingvertical)
        {
            rb.velocity = new Vector2(0, movementDirection.y * movementSpeed * Time.deltaTime);
            wasMovingVertical = true;
            lastMove = new Vector2(0f, movementDirection.y);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        if(Input.GetKey(KeyCode.LeftShift) && energy > 0)
        {
            energy -= decreaseSpeed * Time.deltaTime;

            energy = Mathf.Max(0, energy);

            movementSpeed = 150;
        }
        else
        {
            movementSpeed = 90;
        }
    }
#endregion
}
