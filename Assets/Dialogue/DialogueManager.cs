using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class DialogueManager : MonoBehaviour
{
    public BlinkButton BlinkButton;
    public AudioSource audioSource;
    public AudioClip clicking;
    public AudioClip alarm;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    [SerializeField] dissectionManagerScript managerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Queue<string> dialogues;
    private Queue<string> nameOfSpeaker;
    void Awake()
    {
        dialogues = new Queue<string>();
        nameOfSpeaker = new Queue<string>();
    }
    public void StartDialogue(DialogueStorage dialogue)
    {
        
        dialogues.Clear();
        Debug.Log(dialogue.sentences[0]); 
        foreach (string sentence in dialogue.sentences)
        {
            dialogues.Enqueue(sentence);

        }
        foreach (string name in dialogue.names)
        {
            nameOfSpeaker.Enqueue(name);

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
        if (sentence.Length == 1 && sentence == "#")
        {
            managerScript.setFalseIsDialogueHappening();
            return;
        }
        nameText.text = nameOfSpeaker.Dequeue();
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
    public void EndDialogue()
    {
        
        Debug.Log("End of Conversation");
    }
}
