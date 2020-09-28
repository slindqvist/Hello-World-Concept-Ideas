using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlasticWasteManager : MonoBehaviour {
    public Text _plasticText;
    public int _plasticCount;

    public GameObject _plastic;
    public Transform _rod;
    public Rigidbody _plasticRigidbody;

    void Start() {
        _plasticCount = 1;

        SetPlasticCountText();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("PlasticBin")) {
            Debug.Log("Plastic recycled");
            _plastic.SetActive(false);

            _plasticCount = _plasticCount - 1;

            SetPlasticCountText();
        }
    }

    private void SetPlasticCountText() {
        _plasticText.text = _plasticCount.ToString();
    }

    public void CollectPlasticWaste() {
        _plastic.transform.SetParent(_rod);
        _plasticRigidbody.isKinematic = true;
        Debug.Log("Plastic collected");
    }

    public void PlasticDropZone() {
        _plastic.transform.SetParent(null);
        _plasticRigidbody.isKinematic = false;
        Debug.Log("Plastic unparented");
    }
}
