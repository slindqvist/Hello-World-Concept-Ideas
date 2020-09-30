using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElectronicWasteManager : MonoBehaviour
{
    public Text _electronicText;
    public int _electronicCount;

    //public GameObject _electronic;
    //public Transform _rod;
    //public Rigidbody _electronicRigidbody;

    void Start() {
        _electronicCount = 1;

        SetElectronicCountText();
    }

    public void SetElectronicCountText() {
        _electronicText.text = _electronicCount.ToString();
    }

    //public void CollectElectronicWaste() {
    //    _electronic.transform.SetParent(_rod);
    //    _electronicRigidbody.isKinematic = true;
    //    Debug.Log("Electronic collected");
    //}

    //public void ElectronicDropZone() {
    //    _electronic.transform.SetParent(null);
    //    _electronicRigidbody.isKinematic = false;
    //    Debug.Log("Electronic unparented");
    //}
}
