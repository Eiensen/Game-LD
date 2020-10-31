using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private Joystick joystick;
    private GameObject mainPanel;
   

    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        mainPanel = GameObject.Find("MainPnl");
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DilogMeneger>().StartDialogue(dialogue);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            if (dialogue.isDestroyable)
            {
                Destroy(gameObject);
            }
            joystick.OnPointerUp(null);
            mainPanel.SetActive(false);
            TriggerDialogue();
        }
    }
}
