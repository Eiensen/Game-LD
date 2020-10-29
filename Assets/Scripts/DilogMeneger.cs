﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilogMeneger : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;


    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }   
    
    public void StartDialogue (Dialogue dialogue)
    {
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
        dialogueText.text = sent;
    }

    private void EndDialogue()
    {
        Debug.Log("next");
    }
}
