using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    public Animator transitionAnim;
    public Transform curentPos;
    public UIManager _UIManager;

    public void StartTransition (Transform targetPoint)
    {
        StartCoroutine(TransitionToPoint(targetPoint));
    }


    IEnumerator TransitionToPoint(Transform targetPosition)
    {
        _UIManager.joystick.OnPointerUp(null);
        _UIManager.MainUIPanelSetInactive();
        transitionAnim.SetBool("Start", true);
        yield return new WaitForSeconds(1);
        curentPos.position = targetPosition.position;
        transitionAnim.SetBool("Start", false);
        _UIManager.MainUIPanelSetActiv();
    }
}
