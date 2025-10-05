using UnityEngine;

public class overWorldManagerScript : MonoBehaviour
{
    [SerializeField] private AudioSource ambientBackground;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ambientBackground.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
