using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlasticWasteManager : MonoBehaviour {

    public Text _plasticText;
    public int _plasticCount;

    //public GameObject _plastic; // Skapa en array ca 15 objekt med tags 1-15
    //public Transform _rod;
    //public Rigidbody _rigidbody;

    void Start() {
        _plasticCount = 1;

        SetPlasticCountText();
    }

    public void SetPlasticCountText() {
        _plasticText.text = _plasticCount.ToString();
    }

    //public void CollectPlasticWaste() {
    //    // Skapa en switch sats med cases eller if statement
    //    _plastic.transform.SetParent(_rod);
    //    _rigidbody.isKinematic = true;
    //    Debug.Log("Plastic collected");
    //}

    //public void PlasticDropZone() {
    //    _plastic.transform.SetParent(null);
    //    _rigidbody.isKinematic = false;
    //    Debug.Log("Plastic unparented");
    //}
}
