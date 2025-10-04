using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour 
{
    public void enterGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
