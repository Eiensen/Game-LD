using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    private float speed = 2f;
    public Joystick joystickHor;
    public Joystick joystickVert;
    Vector2 move;

    void Update()
    {
        if(joystickHor.Horizontal >= 0.5f || joystickHor.Horizontal <= -0.5f)
        {
            move.x = joystickHor.Horizontal;
        }
        else
        {
            move.x = 0f;
        }
        if (joystickVert.Vertical >= 0.5f || joystickVert.Vertical <= -0.5f)
        {            
            move.y = joystickVert.Vertical;
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
