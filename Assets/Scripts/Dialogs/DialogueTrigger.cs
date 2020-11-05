using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    
    public Sprite characterImage;
    public Dialogue dialogue;
    private UIManager _UIManager;
    private Image characterImagePanel;
    

    private void Start()
    {
        _UIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        characterImagePanel = GameObject.Find("CharacterImage").GetComponent<Image>();
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
            
            _UIManager.joystick.OnPointerUp(null);
            _UIManager.MainUIPanelSetInactive();
            TriggerDialogue();
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (dialogue.isDestroyable)
            {
                Destroy(gameObject);
            }
            if (dialogue.isMissionNeed)
            {               
                dialogue.gameObjectWithMission.SetActive(true);
            }
            
        }
    }
}
