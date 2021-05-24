using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text scoreText, timerText; 
    private int _score;
    private float _timer;

    private void Start()
    {
        scoreText.text ="Score:0";
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        timerText.text = "Time Taken: " + _timer.ToString("F2");
    }


    public void AddScore(int scoreToAdd)
    {
        _score += scoreToAdd;
        UpdateScoreText();
    }


    public int GetScore()
    {
        return _score;
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + _score;
    }
}
