using UnityEngine;

public class PickUpPlastic : MonoBehaviour {
    PlasticWasteManager _plasticWasteManager;
    ScoreManager _scoreManager;

    private int _recycleValue = 1;

    private void Start() {
        _plasticWasteManager = FindObjectOfType<PlasticWasteManager>();
        _scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("PlasticBin")) {

            _plasticWasteManager._plasticCount = _plasticWasteManager._plasticCount - 1;
            _scoreManager.AddPointsToScoreboard(_recycleValue);

            _plasticWasteManager.SetPlasticCountText();
            Destroy(gameObject);
            Debug.Log("Plastic recycled");
        }
    }
}

