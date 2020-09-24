using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

#region Variables

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

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
        }
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
                animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
                animator.SetFloat("Vertical", 0f);
            }
            else
            {
                rb.velocity = new Vector2(0, movementDirection.y * movementSpeed * Time.deltaTime);
                lastMove = new Vector2(0f, movementDirection.y);
                animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
                animator.SetFloat("Horizontal", 0f);
            }
        }
        else if(isMovingHorizontal)
        {
            rb.velocity = new Vector2(movementDirection.x * movementSpeed * Time.deltaTime, 0);
            wasMovingVertical = false;
            lastMove = new Vector2( movementDirection.x, 0f);
            animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("Vertical", 0f);
        }
        else if(isMovingvertical)
        {
            rb.velocity = new Vector2(0, movementDirection.y * movementSpeed * Time.deltaTime);
            wasMovingVertical = true;
            lastMove = new Vector2(0f, movementDirection.y);
            animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
            animator.SetFloat("Horizontal", 0f);
        }
        else
        {
            rb.velocity = Vector2.zero;
            animator.SetFloat("Horizontal", 0f);
            animator.SetFloat("Vertical", 0f);
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            
        }

        if (collision.collider.tag == "RangedEnemy")
        {

        }
    }
    #endregion
}
