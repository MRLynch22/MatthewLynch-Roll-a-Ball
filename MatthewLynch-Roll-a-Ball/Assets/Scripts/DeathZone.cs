using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
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
            _sceneLoader.RestartScene();
        }
    }
}

