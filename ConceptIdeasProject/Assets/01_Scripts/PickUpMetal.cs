using UnityEngine;

public class PickUpMetal : MonoBehaviour
{
    MetalWasteManager _metalWasteManager;

    private void Start() {
        _metalWasteManager = FindObjectOfType<MetalWasteManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("MetalBin")) {

            _metalWasteManager._metalCount = _metalWasteManager._metalCount - 1;

            _metalWasteManager.SetMetalCountText();
            Destroy(gameObject);
            Debug.Log("Metal recycled");
        }
    }
}
