using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class FleshLayerRemovalScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject part;
    [SerializeField] dissectionManagerScript dissectionManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        GameObject manager = GameObject.Find("Manager");
        dissectionManager = manager.GetComponent<dissectionManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // This code will execute when the GameObject is clicked.
        if (dissectionManager.returnNumOfArmoredParts() == 0 && !dissectionManager.returnIsDialogueHappening())
        {
            if (dissectionManager.returnNumOfFleshParts() == 1)
            {
                Debug.Log("bring up textbox");
                dissectionManager.setTrueIsDialogueHappening();
            }
            Destroy(part);
        }


        // You can add your specific click logic here.
        // For example, changing color, triggering an animation, etc.
    }
}
