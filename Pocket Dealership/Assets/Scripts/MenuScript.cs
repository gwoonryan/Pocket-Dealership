using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenSettingsMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void BackToGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenShopMenu()
    {
        SceneManager.LoadScene(3);
    }
}