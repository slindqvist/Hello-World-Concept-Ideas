using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteSpawner : MonoBehaviour
{
    public GameObject[] _wastePrefab;
    public bool debugMode;
    public float _maxTime = 10f;
    public float _minTime = 5f;

    private GameObject _spawnObject;
    private float _time;
    private float _spawnTime;

    private void Start() {
        
    }

    private void FixedUpdate() {
        _time += Time.deltaTime;
        //Check if it's the right time to spawn
        if(_time >= _spawnTime) {
            Invoke("SpawnWaste", _spawnTime);
            SetRandomTime();
            _time = 0;
        }

        //if (_time <= 0) {
        //    Invoke("SpawnWaste", _spawnTime);

        //    _time = _spawnTime;
        //}
        //else {
        //    _time -= Time.deltaTime;
        //}
    }

    private void SetRandomTime() {
        _spawnTime = Random.Range(_minTime, _maxTime);
        Debug.Log("Next object spawn in " + _spawnTime + " seconds.");
    }

    public void SpawnWaste() {
        Vector3 randomVector = Random.insideUnitSphere;
        Vector3 randomOffset = new Vector3(randomVector.x * transform.lossyScale.x,
                                           randomVector.y * transform.lossyScale.y,
                                           randomVector.z * transform.lossyScale.z);

        GameObject randomFromArray = _wastePrefab[Random.Range(0, _wastePrefab.Length)];
        _spawnObject = Instantiate(randomFromArray, transform.position + randomOffset * 0.5f, transform.rotation);
    }

    public void StopSpawnWaste() {
        CancelInvoke("SpawnWaste");
        Debug.Log("Spawner was canceled");
    }
}
