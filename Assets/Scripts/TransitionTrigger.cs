using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTrigger : MonoBehaviour
{

    public Transform endPoint;
    public UIManager _UIManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {       
        FindObjectOfType<Transitions>().StartTransition(endPoint);
    }

    public void ClickToReturn()
    {
       
        FindObjectOfType<Transitions>().StartTransition(endPoint);
        _UIManager.ResultPanelSetInacrive();
        _UIManager.MainUIPanelSetActiv();
    }
}
