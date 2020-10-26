using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GatheringMetalls gathering_script;

   

    private void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (collision.collider.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "Metall_Iron")
        {
            gathering_script.IronCount++;
            Destroy(collision.gameObject);
        }
    }
    
}
