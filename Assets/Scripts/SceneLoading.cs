using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public void LoadSceneInt(int sceneName)
    {
        Debug.Log($"Loading scene {sceneName}.");
        SceneManager.LoadScene(sceneName);
        
    }


    public void LoadSceneString(string titleScreenScene)
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
