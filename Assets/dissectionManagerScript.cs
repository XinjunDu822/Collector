using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class dissectionManagerScript : MonoBehaviour
{
    //[SerializeField] GameObject[] Heads;
    //[SerializeField] GameObject[] Bodies;
    //[SerializeField] GameObject[] leftArms;
    //[SerializeField] GameObject[] rightArms;
    //[SerializeField] GameObject[] leftLegs;
    //[SerializeField] GameObject[] rightLegs;


    [SerializeField] private List<GameObject> armoredLayer;
    [SerializeField] private GameObject[] fleshLayer;
    [SerializeField] private GameObject[] skeleLayer;
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private DialogueTrigger dialogueTrigger;
    //[SerializeField] GameObject[] bodies;

    private bool canAccessFleshLayer = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueTrigger.TriggerDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool returnCanAccessFleshLayer()
    {
        return canAccessFleshLayer;
    }
}
