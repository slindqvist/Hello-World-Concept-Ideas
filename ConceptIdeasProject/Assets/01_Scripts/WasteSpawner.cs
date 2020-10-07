using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteSpawner : MonoBehaviour {
    public GameObject[] _wastePrefab;
    public bool debugMode;
    public float _maxTime = 10f;
    public float _minTime = 5f;

    private GameObject _spawnObject;
    //private float _time;
    private float _spawnTime;

    private Coroutine SpawnWaste;

    private void Start() {
        SpawnWaste = StartCoroutine(SpawnWasteCoroutine());
    }

    //private void Update() {
    //    _time += Time.deltaTime;
    //    //Check if it's the right time to spawn
    //    if (_time >= _spawnTime) {
    //        if(SpawnWaste == null) {
    //            SpawnWaste = StartCoroutine(SpawnWasteCoroutine()); //Sätt Coroutine = StartCoroutine(IEnumerator);
    //        }
    //        else {
    //            StopCoroutine(SpawnWaste); //Då kan du stoppa den innan du kör den
    //            SpawnWaste = StartCoroutine(SpawnWasteCoroutine());
    //        }
    //        SetRandomTime();
    //        _time = 0;
    //    }
    //}

    private void SetRandomTime() {
        _spawnTime = Random.Range(_minTime, _maxTime);
        Debug.Log("Next object spawn in " + _spawnTime + " seconds.");
    }

    public IEnumerator SpawnWasteCoroutine() {
        while (true) {
            Vector3 randomVector = Random.insideUnitSphere;
            Vector3 randomOffset = new Vector3(randomVector.x * transform.lossyScale.x,
                                               randomVector.y * transform.lossyScale.y,
                                               randomVector.z * transform.lossyScale.z);

            GameObject randomFromArray = _wastePrefab[Random.Range(0, _wastePrefab.Length)];
            _spawnObject = Instantiate(randomFromArray, transform.position + randomOffset * 0.5f, transform.rotation);

            SetRandomTime();
            yield return new WaitForSeconds(_spawnTime);
        }
    }

    public void StopSpawnWaste() {
        //StopCoroutine(SpawnWasteCoroutine());
        if (SpawnWaste != null) {
            StopCoroutine(SpawnWaste);
            Debug.Log("Spawner stopped");
        }
    }
}
