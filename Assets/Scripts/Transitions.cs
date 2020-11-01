using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    public Animator transitionAnim;
    public Transform curentPos;

    public void StartTransition (Transform targetPoint)
    {
        StartCoroutine(TransitionToPoint(targetPoint));
    }


    IEnumerator TransitionToPoint(Transform targetPosition)
    {
        transitionAnim.SetBool("Start", true);
        yield return new WaitForSeconds(1);
        curentPos.position = targetPosition.position;
        transitionAnim.SetBool("Start", false);
    }
}
