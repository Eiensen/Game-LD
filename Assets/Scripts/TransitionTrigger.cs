using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTrigger : MonoBehaviour
{

    public Transform endPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<Transitions>().StartTransition(endPoint);
    }
}
