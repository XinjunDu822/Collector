using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
public class menuScript : MonoBehaviour 
{
    [SerializeField] GameObject settingScreen;
    [SerializeField] GameObject gameButtons;
    [SerializeField] GameObject CreditsText;
    [SerializeField] GameObject credits;
    [SerializeField] GameObject socials;
    [SerializeField] GameObject closeButton;
    [SerializeField] GameObject SocialsButtons;
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider brightnessSlider;

    private void Start()
    {
        volumeSlider.value = (float) 0.5;
        brightnessSlider.value = (float) 0.5;
    }

    public void enterGame()
    {
        SceneManager.LoadScene("Bootup");
    }

    public void openSettings()
    {
        settingScreen.SetActive(true);
        credits.SetActive(false);
        socials.SetActive(false);
        gameButtons.SetActive(false);
        closeButton.SetActive(true);
    }

    public void exit()
    {
        settingScreen.SetActive(false);
        CreditsText.SetActive(false);
        credits.SetActive(true);
        //socials.SetActive(true);
        SocialsButtons.SetActive(false);
        closeButton.SetActive(false);
        gameButtons.SetActive(true);
    }

    public void openCredits()
    {
        gameButtons.SetActive(false);
        socials.SetActive(false);
        CreditsText.SetActive(true);
        closeButton.SetActive(true);
    }

    public void openSocials()
    {
        gameButtons.SetActive(false);
        socials.SetActive(false);
        credits.SetActive(false);
        SocialsButtons.SetActive(true);
        closeButton.SetActive(true);
    }

    public void setVolume()
    {
        float volume = volumeSlider.value;
        mixer.SetFloat("volume", 20 + Mathf.Log10(volume)*35);
    }

   /* public void setBrightness()
    {
        var tempColor = overlay.color;
        tempColor.a = brightnessSlider.value;
        overlay.color = tempColor;
    } */
}
