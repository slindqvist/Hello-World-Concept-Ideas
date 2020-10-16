using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI _timerText;
    public TextMeshProUGUI _gameOverText;
    public float _totalTime = 180f;

    private float _minutes;
    private float _seconds;

    void Start()
    {
        _gameOverText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        CountDownTimer();
    }

    public void CountDownTimer() {
        _totalTime -= Time.deltaTime;

        _minutes = (int)(_totalTime / 60);
        _seconds = (int)(_totalTime % 60);

        _timerText.text = _minutes.ToString() + ":" + _seconds.ToString();

        if (_minutes == 0 && _seconds == 10) {
            _timerText.color = Color.red;
        }

        if(_minutes == 0 && _seconds == 0) {
            _timerText.enabled = false;
            _gameOverText.enabled = true;
        }
    }


}
