using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void OnPlay(string gameSceneName)
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void OnOptions()
    {
        SceneManager.LoadSceneAsync("Options", LoadSceneMode.Additive);
    }

    public void OnAbout()
    {
        SceneManager.LoadScene("About");
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
