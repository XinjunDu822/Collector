using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class dissectionManagerScript : MonoBehaviour
{
    //[SerializeField] GameObject[] Heads;
    //[SerializeField] GameObject[] Bodies;
    //[SerializeField] GameObject[] leftArms;
    //[SerializeField] GameObject[] rightArms;
    //[SerializeField] GameObject[] leftLegs;
    //[SerializeField] GameObject[] rightLegs;


    [SerializeField] private List<GameObject> armoredLayer;
    [SerializeField] private List<GameObject> fleshLayer;
    [SerializeField] private GameObject[] skeleLayer;
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private DialogueTrigger dialogueTrigger;
    [SerializeField] private GameObject dialogueBox;
    //[SerializeField] GameObject[] bodies;

    //private bool canAccessFleshLayer;
    private bool isDialogueHappening = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueTrigger.TriggerDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int returnNumOfArmoredParts()
    {
        int count = 0;
        for (int i = 0; i < armoredLayer.Count; i++)
        {
            if (armoredLayer[i] != null)
            {
                count++;
            }
        }
        return count;
    }
    public int returnNumOfFleshParts()
    {
        int count = 0;
        for (int i = 0; i < fleshLayer.Count; i++)
        {
            if (fleshLayer[i] != null)
            {
                count++;
            }
        }
        return count;
    }


    public bool returnIsDialogueHappening()
    {
        return isDialogueHappening;
    }

    public void setTrueIsDialogueHappening()
    {
        isDialogueHappening = true;
        dialogueManager.DisplayNextSentence();
    }

    public void setFalseIsDialogueHappening()
    {
        dialogueManager.nameText.SetText("");
        dialogueManager.dialogueText.SetText("");
        isDialogueHappening = false;
    }
}
