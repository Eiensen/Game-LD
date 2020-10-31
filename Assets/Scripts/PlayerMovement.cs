using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    private float speed = 2f;
    public Joystick joystick;
    
    Vector2 move;

    void Update()
    {
        if(joystick.Horizontal >= 0.5f || joystick.Horizontal <= -0.5f)
        {
            move.x = joystick.Horizontal;
        }
        else
        {
            move.x = 0f;
        }
        if (joystick.Vertical >= 0.5f || joystick.Vertical <= -0.5f)
        {            
            move.y = joystick.Vertical;
        }
        else
        {
            move.y = 0f;
        }

        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.y);
        animator.SetFloat("Speed", move.magnitude);


        
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}
