using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class limbRemovalScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject[] Heads;
    [SerializeField] GameObject[] Bodies;
    [SerializeField] GameObject[] leftArms;
    [SerializeField] GameObject[] rightArms;
    [SerializeField] GameObject[] leftLegs;
    [SerializeField] GameObject[] rightLegs;
    [SerializeField] GameObject part;
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
        part.SetActive(false);

            // You can add your specific click logic here.
            // For example, changing color, triggering an animation, etc.
    }

}
