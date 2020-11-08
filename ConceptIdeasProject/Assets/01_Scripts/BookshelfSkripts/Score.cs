using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Score based on timer
    private float _timeElapsed;
    private float _maxTime = 210;
    private float _bonusScore = 1;
    private float _timerScore;
    public int _totScore;

    public static int _score = 0;

    public Text _scoreText;

    public void Update()
    {
        _scoreText.text = _score.ToString();
    }

    public void AssigBonusPoints() {
        _timerScore = Mathf.Max(0, _maxTime - _timeElapsed) * _bonusScore;
        _totScore = _score + (int)_timerScore;
        Debug.Log("Bonus " + _timerScore);
    }
}
