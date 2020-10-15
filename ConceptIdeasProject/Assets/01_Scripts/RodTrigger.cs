using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodTrigger : MonoBehaviour
{
    public Transform _stand;

    private Renderer _rodRenderer;
    private Rigidbody _rodRigidbody;
    private bool _hasSpawned;

    public float _respawnTime = 2f;

    private void Start() {
        _rodRenderer = GetComponent<Renderer>();
        _rodRigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Drop Zone")) {
            DestroyRod();
        }

        if (other.gameObject.CompareTag("Shark")) {
            DestroyRod();
        }
    }

    private void DestroyRod() {
        _rodRenderer.enabled = false;
        Invoke("RespawnRod", _respawnTime);
        _rodRigidbody.isKinematic = true;
        _hasSpawned = false;
    }

    private void RespawnRod() {
        if(_hasSpawned == false) {
            transform.position = _stand.position;
            transform.rotation = _stand.rotation;
            _rodRenderer.enabled = true;
            _rodRigidbody.isKinematic = false;
            _hasSpawned = true;
        }
    }
}
