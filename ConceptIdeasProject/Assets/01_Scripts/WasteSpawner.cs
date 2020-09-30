using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteSpawner : MonoBehaviour
{
    public Transform[] _spawnPoints;
    public GameObject[] _wastePrefab;

    public float _currentSpawnTime = 0f;
    public float _spawnInterval = 5f;

    public float _countdown = 10f;
    public float _currentTime = 0f;

    private void Update() {
        _currentSpawnTime += Time.deltaTime;
        _currentTime += Time.deltaTime;

        if(_currentSpawnTime >= _spawnInterval) {
            SpawnWaste();
            _currentSpawnTime = 0;
        }

        if(_currentTime >= _countdown) {
            _spawnInterval -= 0.1f;
            _currentTime = 0;
        }
    }

    private void SpawnWaste() {
        int spawnPointIndex = Random.Range(0, _spawnPoints.Length);
        int wastePrefabIndex = Random.Range(0, _wastePrefab.Length);
        Instantiate(_wastePrefab[wastePrefabIndex], _spawnPoints[spawnPointIndex].position, _spawnPoints[spawnPointIndex].rotation);
    }
}
