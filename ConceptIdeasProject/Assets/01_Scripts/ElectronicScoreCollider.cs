using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronicScoreCollider : MonoBehaviour
{
    ScoreManager _scoreManager;

    private int _targetHitValue = 10;

    private void Start() {
        _scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Electronic")) {
            //Set score +10p
            _scoreManager.AddPointsToScoreboard(_targetHitValue);
        }
    }
}
