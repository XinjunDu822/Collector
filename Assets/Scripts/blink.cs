using UnityEngine;
using UnityEngine.UI;

public class BlinkButton : MonoBehaviour
{
    public GameObject button;
    [SerializeField] AudioClip alarm;
    private float timer;
    public AudioSource audioSource;

    public void blink(float blinkInterval, int numOfBlinks)
    {
        audioSource.PlayOneShot(alarm);
        timer += Time.deltaTime;
        if (timer >= blinkInterval)
        {
            button.SetActive(!button.activeSelf); // toggle on/off
            timer = 0f;
        }
    }
}
