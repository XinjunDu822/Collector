using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class dialogueBoxScript : MonoBehaviour, IPointerClickHandler

{
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] dissectionManagerScript dissectionManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // This code will execute when the GameObject is clicked.
        if (dissectionManager.returnIsDialogueHappening())
            dialogueManager.DisplayNextSentence();

        // You can add your specific click logic here.
        // For example, changing color, triggering an animation, etc.
    }
}
