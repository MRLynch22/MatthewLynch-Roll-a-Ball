using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameController : MonoBehaviour
{
    public TMP_Text scoreText, timerText, endScoreText, endTimerText;
    public GameObject endLevelScreen;
    private int _score, _maxScore;
    private float _timer;
    private SceneLoader _sceneLoader;
    public bool isCountingUp;

    private void Start()
    {
        _sceneLoader = GetComponent<SceneLoader>();
        ScorePickup[] scorePickups = FindObjectsOfType<ScorePickup>();
        foreach (ScorePickup item in scorePickups)
        {
            _maxScore += item.scoreValue;
        }

        scoreText.text = "Score:0/" + _maxScore;
    }

    public void EndLevel()
    {
        endLevelScreen.SetActive(true);
        scoreText.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
        endTimerText.text = "Time Taken: " + _timer.ToString("F2");
        endScoreText.text = "Score: " + _score + "/" + _maxScore;
        FindObjectOfType<BallController>().DisabledBallController();
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
        scoreText.text = "Score: " + _score + "/" + _maxScore;
    }
}
