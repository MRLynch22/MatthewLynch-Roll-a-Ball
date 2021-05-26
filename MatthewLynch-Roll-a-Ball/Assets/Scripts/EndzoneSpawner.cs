using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndzoneSpawner : MonoBehaviour
{
    public GameObject endZone;

    public float spawnDelay = 5f;
    private float _spawnDelayTimer;
    private bool _spawnDelayComplate;

    private void Update()
    {
        //if you change the names of everything below it can be used as a timer
        if(_spawnDelayComplate == false)
        {
            _spawnDelayTimer += Time.deltaTime;
            if(_spawnDelayTimer >= spawnDelay)
            {
                _spawnDelayComplate = true;
                endZone.SetActive (true);
            }
        }
    }
}
