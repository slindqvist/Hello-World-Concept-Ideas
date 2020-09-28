using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFromWater : MonoBehaviour {
    public GameObject _plastic, _metal, _electronic;

    public Transform _rod;

    public bool _isPlastic, _isMetal, _isElectronic;

    private Rigidbody _pRigidbody, _mRigidbody, _eRigidbody;

    private void Start() {
        _pRigidbody = GetComponent<Rigidbody>();
        _mRigidbody = GetComponent<Rigidbody>();
        _eRigidbody = GetComponent<Rigidbody>();
    }

    // Får enbart ett objekt att fångas upp med hjälp av håven oavsett vilken jag kolliderar med.
    // Om jag tar bort övrig kod fungerar det som det ska, aktiveras genom Unity Events
    public void CollectPlasticWaste() {
            _plastic.transform.SetParent(_rod);
            _pRigidbody.isKinematic = true;
            _isPlastic = true;
            Debug.Log("Plastic collected");
    }

    //public void CollectMetalWaste(Transform rod) {
    //    _metal.transform.SetParent(rod);
    //    _mRigidbody.isKinematic = true;
    //    _isMetal = true;
    //    Debug.Log("Metal collected");
    //}

    //public void CollectElectronicWaste(Transform rod) {
    //    _electronic.transform.SetParent(rod);
    //    _eRigidbody.isKinematic = true;
    //    _isElectronic = true;
    //    Debug.Log("Electronic collected");
    //}

    public void PlasticDropZone() {
        _plastic.transform.SetParent(null);
        _pRigidbody.isKinematic = false;
        Debug.Log("Plastic unparented");
    }
}
