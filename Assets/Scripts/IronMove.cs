using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMove : MonoBehaviour
{
    private float speed;
    void Start()
    {
        speed = Random.Range(2, 6);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if(transform.position.y < 9)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //FindObjectOfType<Menu>().Pause();
        }
    }
}
