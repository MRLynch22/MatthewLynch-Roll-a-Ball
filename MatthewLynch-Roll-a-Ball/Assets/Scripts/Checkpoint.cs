﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform checkpointPosition;


    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<BallController>().respawnPosition = checkpointPosition;
        }
    }






}



