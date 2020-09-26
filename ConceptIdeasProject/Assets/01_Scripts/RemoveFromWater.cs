using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFromWater : MonoBehaviour
{
    public GameObject _waste;
    public Transform _rod;

    private Rigidbody _rigidbody;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void CollectWaste(Transform rod) {
        _waste.transform.SetParent(rod);
        _rigidbody.isKinematic = true;
        Debug.Log("Trash collected");
    }

    public void DropWaste() {
        _waste.transform.SetParent(null);
        _rigidbody.isKinematic = false;
        Debug.Log("Unparented");
    }
}
