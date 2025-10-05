using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
public class menuScript : MonoBehaviour 
{
    [SerializeField] GameObject settingScreen;
    [SerializeField] AudioMixer mixer;
    public void enterGame()
    {
        SceneManager.LoadScene("overworld");
    }

    public void openSettings()
    {
        settingScreen.SetActive(true);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void exitSetting()
    {
        settingScreen.SetActive(false);
    }

    public void setVolume(float volume)
    {
        mixer.SetFloat("volume", volume);
    }
}
