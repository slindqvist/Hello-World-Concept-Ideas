using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;

    public float _amplitude = 1f;
    public float _length = 2f;
    public float _speed = 1f;
    public float _offset = 0f;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else if (instance != this) {
            Debug.Log("Instance already exist, destroying this object!");
            Destroy(this);
        }
    }

    private void Update() {
        _offset += Time.deltaTime * _speed;
    }

    public float GetWaveHeight(float _x) {
        return _amplitude * Mathf.Sin(_x / _length + _offset);
    }
}
