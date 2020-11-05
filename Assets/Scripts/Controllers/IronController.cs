using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronController : MonoBehaviour
{
    public new GameObject light;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
           
            light.SetActive(false);
            //Destroy(gameObject);
        }
    }
}
