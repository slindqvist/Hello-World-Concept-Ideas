using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticScoreCollider : MonoBehaviour
{
    ScoreManager _scoreManager;
    AudioManager _audioManager;

    private int _targetHitValue = 10;

    private void Start() {
        _scoreManager = FindObjectOfType<ScoreManager>();
        _audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Plastic")) {
            _audioManager.PlayScorePoint();
            //Set score +10p
            _scoreManager.AddPointsToScoreboard(_targetHitValue);
        }
    }
}
