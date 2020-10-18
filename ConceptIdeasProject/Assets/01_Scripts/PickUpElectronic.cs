﻿using UnityEngine;

public class PickUpElectronic : MonoBehaviour
{
    ElectronicWasteManager _electronicWasteManager;
    ScoreManager _scoreManager;
    AudioManager _audioManager;

    private int _recycleValue = 1;

    private void Start() {
        _electronicWasteManager = FindObjectOfType<ElectronicWasteManager>();
        _scoreManager = FindObjectOfType<ScoreManager>();
        _audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("ElectronicBin")) {
            // Play collision sound when hitting the bin
            _audioManager.PlayElectronicDrop();

            _electronicWasteManager._electronicCount = _electronicWasteManager._electronicCount - 1;
            _scoreManager.AddPointsToScoreboard(_recycleValue);

            _electronicWasteManager.SetElectronicCountText();
            Destroy(gameObject);
            Debug.Log("Electronic recycled");
        }
    }
}
