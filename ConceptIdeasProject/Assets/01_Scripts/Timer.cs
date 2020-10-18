using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    AudioManager _audioManager;

    public TextMeshProUGUI _timerText;
    public TextMeshProUGUI _gameOverText;
    public float _timeRemaining = 180f;

    private bool _timerIsRunning;
    private bool _gameOver;

    void Start()
    {
        _audioManager = FindObjectOfType<AudioManager>();
        _gameOverText.enabled = false;
        _timerIsRunning = true;
    }

    void Update()
    {
        CountDownTimer();
    }

    public void CountDownTimer() {
        if(_timeRemaining > 0) {
            _timeRemaining -= Time.deltaTime;
            DisplayTime(_timeRemaining);
        }
        else {
            // Game over text
            Debug.Log("Time has run out!");
            _timerText.enabled = false;
            _gameOverText.enabled = true;
            _timeRemaining = 0;
            _timerIsRunning = false;
        }
    }

    void DisplayTime(float timeToDisplay) {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        _timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if(minutes == 0 && seconds == 10) {
            _timerText.color = Color.red;
            // Play timer sound
            _audioManager.PlayTimerCountdown();
        }
    }
}
