using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteSpawner : MonoBehaviour
{
    public GameObject[] _wastePrefab;
    public float _spawnTime = 10f;
    public bool debugMode;

    private GameObject _spawnObject;
    private float _spawnCounter;

    private void Update() {
        if (_spawnCounter <= 0) {
            Invoke("SpawnWaste", _spawnTime);

            _spawnCounter = _spawnTime;
        }
        else {
            _spawnCounter -= Time.deltaTime;
        }
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
