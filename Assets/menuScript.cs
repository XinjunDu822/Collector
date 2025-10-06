using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
public class menuScript : MonoBehaviour 
{
    [SerializeField] GameObject settingScreen;
    [SerializeField] GameObject gameButtons;
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
        gameButtons.SetActive(false);
    }

    public void exitSettings()
    {
        settingScreen.SetActive(false);
        gameButtons.SetActive(true);
    }

    public void exitGame()
    {
        Application.Quit();
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
