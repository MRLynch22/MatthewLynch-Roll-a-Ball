using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class CountDownTimer : MonoBehaviour
{
    public float timeToDisplay = 90;
    public bool timerIsRunning = false;
    public TMP_Text text; 

    private void Start()
    {
        timerIsRunning = true;
    }

    void Update()
    {
            if (timeToDisplay > 0)
            {
                timeToDisplay -= Time.deltaTime;
            }
            else
            {
            timeToDisplay = 0;
            }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
