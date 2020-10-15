using UnityEngine;

public class PickUpPlastic : MonoBehaviour {
    PlasticWasteManager _plasticWasteManager;

    private void Start() {
        _plasticWasteManager = FindObjectOfType<PlasticWasteManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("PlasticBin")) {

            _plasticWasteManager._plasticCount = _plasticWasteManager._plasticCount - 1;

            _plasticWasteManager.SetPlasticCountText();
            Destroy(gameObject);
            Debug.Log("Plastic recycled");
        }
    }
}

