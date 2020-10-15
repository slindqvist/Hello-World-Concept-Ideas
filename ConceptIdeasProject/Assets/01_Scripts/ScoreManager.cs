using UnityEngine;

public class ScoreManager : MonoBehaviour {
    private PlasticWasteManager _plasticManager;
    private MetalWasteManager _metalManager;
    private ElectronicWasteManager _electronicManager;
    private WasteSpawner _wasteSpawner;

    public bool _firstLevelComplete;

    private float _score = 0f;

    void Start() {
        _plasticManager = FindObjectOfType<PlasticWasteManager>();
        _metalManager = FindObjectOfType<MetalWasteManager>();
        _electronicManager = FindObjectOfType<ElectronicWasteManager>();
        _wasteSpawner = FindObjectOfType<WasteSpawner>();

        _firstLevelComplete = false;
    }

    void Update() {
        if (!_firstLevelComplete) {
            if (_plasticManager._plasticCount == _score) {
                if (_metalManager._metalCount == _score) {
                    if (_electronicManager._electronicCount == _score) {
                        // Close spawner
                        _wasteSpawner.StopSpawnWaste();

                        _firstLevelComplete = true;
                        Debug.Log("Level 1 Complete");
                    }
                }
            }
        }
    }
}
