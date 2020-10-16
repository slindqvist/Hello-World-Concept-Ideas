using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI _timerText;
    public TextMeshProUGUI _gameOverText;
    public float _totalTime;

    private float _minutes;
    private float _seconds;

    void Start()
    {
        _gameOverText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
