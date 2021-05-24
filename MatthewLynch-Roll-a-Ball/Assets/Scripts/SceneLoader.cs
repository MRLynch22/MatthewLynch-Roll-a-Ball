using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string nextScene;

    private void LoadScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }

    public void RestartScene()
    {
        LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextScene()
    {
        LoadScene(nextScene);
    }
}
