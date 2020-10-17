using UnityEngine;

public class PickUpMetal : MonoBehaviour
{
    MetalWasteManager _metalWasteManager;
    ScoreManager _scoreManager;

    private int _recycleValue = 1;

    private void Start() {
        _metalWasteManager = FindObjectOfType<MetalWasteManager>();
        _scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("MetalBin")) {

            _metalWasteManager._metalCount = _metalWasteManager._metalCount - 1;
            _scoreManager.AddPointsToScoreboard(_recycleValue);

            _metalWasteManager.SetMetalCountText();
            Destroy(gameObject);
            Debug.Log("Metal recycled");
        }
    }
}
