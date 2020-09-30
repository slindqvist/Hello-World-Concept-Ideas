using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetalWasteManager : MonoBehaviour
{
    public Text _metalText;
    public int _metalCount;

    //public GameObject _metal;
    //public Transform _rod;
    //public Rigidbody _metalRigidbody;

    void Start() {
        _metalCount = 1;

        SetMetalCountText();
    }

    public void SetMetalCountText() {
        _metalText.text = _metalCount.ToString();
    }

    //public void CollectMetalWaste() {
    //    _metal.transform.SetParent(_rod);
    //    _metalRigidbody.isKinematic = true;
    //    Debug.Log("Metal collected");
    //}

    //public void MetalDropZone() {
    //    _metal.transform.SetParent(null);
    //    _metalRigidbody.isKinematic = false;
    //    Debug.Log("Metal unparented");
    //}
}
