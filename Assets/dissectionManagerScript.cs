using UnityEngine;

public class dissectionManagerScript : MonoBehaviour
{
    [SerializeField] GameObject[] Heads;
    [SerializeField] GameObject[] Bodies;
    [SerializeField] GameObject[] leftArms;
    [SerializeField] GameObject[] rightArms;
    [SerializeField] GameObject[] leftLegs;
    [SerializeField] GameObject[] rightLegs;


    [SerializeField] GameObject[] armoredLayer;
    [SerializeField] GameObject[] fleshLayer;
    [SerializeField] GameObject[] skeleLayer;
    [SerializeField] DialogueManager dialogueManager;
    //[SerializeField] GameObject[] bodies;

    private bool canAccessFleshLayer = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
