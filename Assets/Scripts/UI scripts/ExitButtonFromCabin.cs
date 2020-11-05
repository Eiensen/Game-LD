using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonFromCabin : MonoBehaviour
{
    public UIManager _UIManager;
    public GameObject player;
   
    void Update()
    {
        if(player.transform.position == transform.position)
        {
           _UIManager.ReturnButtonSetActive();
        }
    }
}
