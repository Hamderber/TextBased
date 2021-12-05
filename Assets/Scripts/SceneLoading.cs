using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public GameObject StartMainMenu;
    public GameObject go_OptionsMenu;
    public GameObject go_AudioMenu;
    public GameObject go_GraphicsMenu;

    public void LoadScene(int sceneName)
    {
        Debug.Log($"Loading scene {sceneName}.");
        SceneManager.LoadScene(sceneName);
        
    }

    public void Test()
    {
        Debug.Log("Test");
    }

    public void Start()
    {
        /*GameObject[] gameObjectMenus = new GameObject[] { StartMainMenu, go_OptionsMenu, go_AudioMenu, go_GraphicsMenu };
        foreach (var menu in gameObjectMenus)
        {
            //temporarily loads all menus so they can set default values
            Debug.Log($"Set {menu.name} to active.");
            menu.SetActive(true);
            menu.SetActive(false);
            Debug.Log($"Set {menu.name} to inactive.");
        }
        Debug.Log($"Set {StartMainMenu} to active.");
        gameObjectMenus[0].SetActive(true);*/

    }
}
