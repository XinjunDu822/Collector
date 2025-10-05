using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class FleshLayerRemovalScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject part;
    [SerializeField] dissectionManagerScript manager;
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
        if (manager.returnCanAccessFleshLayer())
            part.SetActive(false);

        // You can add your specific click logic here.
        // For example, changing color, triggering an animation, etc.
    }
}
