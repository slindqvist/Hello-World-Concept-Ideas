using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpElectronic : MonoBehaviour
{
    ElectronicWasteManager _electronicWasteManager;

    private void Start() {
        _electronicWasteManager = FindObjectOfType<ElectronicWasteManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("ElectronicBin")) {

            _electronicWasteManager._electronicCount = _electronicWasteManager._electronicCount - 1;

            _electronicWasteManager.SetElectronicCountText();
            Destroy(gameObject);
            Debug.Log("Electronic recycled");
        }
    }
}
