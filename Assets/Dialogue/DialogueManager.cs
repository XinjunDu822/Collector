using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class DialogueManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clicking;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue (DialogueStorage dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);
        nameText.text = dialogue.name;
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
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

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

        Debug.Log(sentence);

    }
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            audioSource.PlayOneShot(clicking);
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
            
        }
    }
    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }
}
