using UnityEngine;
using System.Collections;
using TMPro;

public class ScoreManager : MonoBehaviour {
    private PlasticWasteManager _plasticManager;
    private MetalWasteManager _metalManager;
    private ElectronicWasteManager _electronicManager;
    private WasteSpawner _wasteSpawner;
    private WinSceneAnimControl _winSceneAnimControl;
    private Highscores _highscores;

    public bool _firstLevelComplete;
    private float _score = 0f;

    public TextMeshProUGUI _scoreboardText;
    private int _points;

    public GameObject _placeHolder;
    public float waitTime = 10f;

    void Start() {
        _plasticManager = FindObjectOfType<PlasticWasteManager>();
        _metalManager = FindObjectOfType<MetalWasteManager>();
        _electronicManager = FindObjectOfType<ElectronicWasteManager>();
        _wasteSpawner = FindObjectOfType<WasteSpawner>();
        _winSceneAnimControl = FindObjectOfType<WinSceneAnimControl>();
        _highscores = FindObjectOfType<Highscores>();

        _firstLevelComplete = false;

        _points = 0;
        _scoreboardText.text = "Bonus: " + _points + "p";
    }

    void Update() {
        if (!_firstLevelComplete) {
            if (_plasticManager._plasticCount == _score) {
                if (_metalManager._metalCount == _score) {
                    if (_electronicManager._electronicCount == _score) {
                        _wasteSpawner.StopSpawnWaste();
                        _winSceneAnimControl.PlayWinScene();
                        _firstLevelComplete = true;
                        StartCoroutine("GameOverCoroutine");
                        Debug.Log("Level 1 Complete");
                    }
                }
            }
        }
    }

    public void AddPointsToScoreboard(int amount) {
        _points = _points + amount;
        _scoreboardText.text = "Bonus: " + _points + "p";
    }

    public void SubtractPointsToScoreboard(int amount) {
        _points = _points - amount;
        _scoreboardText.text = "Bonus: " + _points + "p";
    }

    public IEnumerator GameOverCoroutine() {
        _highscores.AddNewHighscore("Spelare", _points);
        yield return new WaitForSeconds(waitTime);
        _placeHolder.SetActive(true);
        Debug.Log("Returning to Start scene...");
    }
}
