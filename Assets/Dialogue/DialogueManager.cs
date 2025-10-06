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
    private Queue<string> dialogues;

    void Awake()
    {
        dialogues = new Queue<string>();
    }
    public void StartDialogue(DialogueStorage dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);
        nameText.text = dialogue.name;
        //sentences.Clear();
        Debug.Log(dialogue.sentences[0]); 
        foreach (string sentence in dialogue.sentences)
        {
            dialogues.Enqueue(sentence);

        }
        Debug.Log("Display next");
        DisplayNextSentence();

    }
    public void DisplayNextSentence()
    {

        if (dialogues.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = dialogues.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

        Debug.Log(sentence);

    }
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        //Debug.
        foreach(char letter in sentence.ToCharArray())
        {
            audioSource.PlayOneShot(clicking);
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.04f);
            
        }
    }
    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }
}
