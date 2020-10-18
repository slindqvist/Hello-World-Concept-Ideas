using UnityEngine;

public class PickUpPlastic : MonoBehaviour {
    PlasticWasteManager _plasticWasteManager;
    ScoreManager _scoreManager;
    AudioManager _audioManager;

    private int _recycleValue = 1;

    private void Start() {
        _plasticWasteManager = FindObjectOfType<PlasticWasteManager>();
        _scoreManager = FindObjectOfType<ScoreManager>();
        _audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("PlasticBin")) {
            _audioManager.PlayPlasticDrop();

            _plasticWasteManager._plasticCount = _plasticWasteManager._plasticCount - 1;
            _scoreManager.AddPointsToScoreboard(_recycleValue);

            _plasticWasteManager.SetPlasticCountText();
            Destroy(gameObject);
            Debug.Log("Plastic recycled");
        }
    }
}

