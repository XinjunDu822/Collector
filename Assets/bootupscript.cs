using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class bootupscript : MonoBehaviour
{
    [SerializeField] GameObject start;
    [SerializeField] GameObject memTest;
    [SerializeField] GameObject Part2;
    [SerializeField] List<GameObject> detecs;
    [SerializeField] GameObject Screen1;
    [SerializeField] GameObject Screen2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(wait());
    }

    public void exitScene()
    {
        SceneManager.LoadScene("overworld");
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(1);
        start.SetActive(false);
        Screen1.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        memTest.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        Part2.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        for (int i = 0; i < detecs.Count; i++)
        {
            yield return new WaitForSecondsRealtime(1);
            detecs[i].SetActive(true);
        }
        yield return new WaitForSecondsRealtime(1);
        Screen1.SetActive(false);
        Screen2.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene("overworld");
    }
}
