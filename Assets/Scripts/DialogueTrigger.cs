using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//using UnityEngine.UIElements;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Sprite characterImage;
    public Dialogue dialogue;
    private Joystick joystick;
    private GameObject mainPanel;
    private Image characterImagePanel;
   

    private void Start()
    {
        characterImagePanel = GameObject.Find("CharacterImage").GetComponent<Image>();
        joystick = FindObjectOfType<Joystick>();
        mainPanel = GameObject.Find("MainPnl");
        
    }

    public void TriggerDialogue()
    {
        characterImagePanel.sprite = characterImage;
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
