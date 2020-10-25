using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 3f;
    private Transform player;
    Vector2 movement;
    private bool isMoving = true;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        if (isMoving)
        {
            moveEnemy(movement);
        }           
    }
    public void SetIsMoving(bool value)
    {
        isMoving = value;        
    }
    public void moveEnemy(Vector2 dir)
    {
       
        rb.MovePosition((Vector2)transform.position + (dir * speed * Time.deltaTime));
             
    }
}
