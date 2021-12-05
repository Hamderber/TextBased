using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(string startingScene)
    {
        Debug.Log($"Loading scene {startingScene}.");
        SceneManager.LoadScene(startingScene);
    }

    public void TitleScreen(string titleScreenScene)
    {
        Debug.Log($"Loading scene {titleScreenScene}.");
        SceneManager.LoadScene(titleScreenScene);
    }

    public void QuitGame()
    {
        Debug.Log("Application quitting.");
        Application.Quit();
    }
}
