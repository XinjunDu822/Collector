using UnityEngine;
using UnityEngine.UI;

public class ShowButtonOnApproach : MonoBehaviour
{
    public GameObject buttonUI;  // assign your Button in the Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            buttonUI.SetActive(true);  // show button
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            buttonUI.SetActive(false); // hide button
        }
    }
}