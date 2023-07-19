using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public SceneLoaderScript loader;
    public void PlayGame()
    {
        loader.LoadScene(2);
    }
    public void OpenSettingsMenu()
    {
        loader.LoadScene(1);
    }
    public void BackToGame()
    {
        loader.LoadScene(2);
    }
    public void OpenShopMenu()
    {
        loader.LoadScene(3);
    }
}