using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilogMeneger : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    public GameObject joystickPanel;
    public GameObject mainPanel;

    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }   
    
    public void StartDialogue (Dialogue dialogue)
    {
        joystickPanel.SetActive(false);
        animator.SetBool("isOpen", true);
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (var sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
       if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sent = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sent));
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach ( char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    private void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        joystickPanel.SetActive(true);
        if (!mainPanel.activeInHierarchy)
        {
            mainPanel.SetActive(true);
        }
    }
}
