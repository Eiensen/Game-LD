using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    private float speed = 100f;
    public Joystick joystick;
    
    Vector2 move;

    private void FixedUpdate()
    {
        if (joystick.Horizontal >= 0.3f || joystick.Horizontal <= -0.3f)
        {
            move.x = joystick.Horizontal;
        }
        else
        {
            move.x = 0f;
        }
        if (joystick.Vertical >= 0.3f || joystick.Vertical <= -0.3f)
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
        rb.velocity = new Vector2(move.x, move.y) * speed * Time.fixedDeltaTime;
    }
}
