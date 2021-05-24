using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{
    private SceneLoader _sceneLoader;

    private void Start()
    {
        _sceneLoader = FindObjectOfType<SceneLoader>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _sceneLoader.LoadNextScene();
        }
    }
}
