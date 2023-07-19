using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderScript : MonoBehaviour
{

    private void Start()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }

    public Animator crossfade;
    public void LoadScene(int scene)
    {
        StartCoroutine(LoadSceneDelay(scene));
    }

    IEnumerator LoadSceneDelay(int scene)
    {
        crossfade.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(scene);
    }
}
