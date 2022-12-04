using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator anim;

    private bool grounded;
    [SerializeField] private float speed;
    [SerializeField] private float jump;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        movement();
    }

    private void movement()
    {
        //Sets the player movement on x axis.
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //flip the player object when changing directions.
        if (horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        } else if (horizontalInput < -0.01f) {
            transform.localScale = Vector3.one;
        }
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            Jumping();
        }

        //Setting the animator parameters.
        anim.SetBool("IsRunning", horizontalInput !=0);
        anim.SetBool("IsGrounded", grounded);
    }
    //Sets the jump and starts the animation. Turns grounded to false till touching ground tag again.
    private void Jumping()
    {
        body.velocity = new Vector2(body.velocity.x, jump);
        anim.SetTrigger("Jump");
        grounded = false;
    }
    //Checks if player is touching the Ground and sets grounded to true.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
