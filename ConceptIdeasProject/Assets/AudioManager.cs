using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioSource _plasticRecycleSound, _metalRecycleSound, _electronicRecycleSound, _rodSound, _scoreSound, _timerSound, _sharkBiteSound;

    public void PlayPlasticDrop() {
        if (!_plasticRecycleSound.isPlaying) {
            _plasticRecycleSound.pitch = Random.Range(0.5f, 2f);
            _plasticRecycleSound.Play();
        }
    }

    public void PlayMetalDrop() {
        if (!_metalRecycleSound.isPlaying) {
            _metalRecycleSound.pitch = Random.Range(0.5f, 2f);
            _metalRecycleSound.Play();
        }
    }

    public void PlayElectronicDrop() {
        if (!_electronicRecycleSound.isPlaying) {
            _electronicRecycleSound.pitch = Random.Range(0.5f, 2f);
            _electronicRecycleSound.Play();
        }
    }

    public void PlayRodSplash() {
        if (!_rodSound.isPlaying) {
            _rodSound.Play();
        }
    }

    public void PlayScorePoint() {
        if (!_scoreSound.isPlaying) {
            _scoreSound.Play();
        }
    }

    public void PlayTimerCountdown() {
        if (!_timerSound.isPlaying) {
            _timerSound.Play();
        }
    }

    public void PlaySharkAttack() {
        if (!_sharkBiteSound.isPlaying) {
            _sharkBiteSound.Play();
        }
    }
}
