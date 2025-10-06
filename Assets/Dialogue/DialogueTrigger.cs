using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DialogueTrigger : MonoBehaviour
{
    public DialogueStorage dialogue;

    public void TriggerDialogue()
    {
        Debug.Log("Found");
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

    }
}
