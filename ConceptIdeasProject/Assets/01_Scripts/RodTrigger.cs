﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodTrigger : MonoBehaviour {
    public Transform _stand;
    public float _respawnTime = 2f;

    private Material[] _previousMaterial;
    private Renderer[] _rodRenderers;
    private bool _hasSpawned;
    
    private void Start() {
        _rodRenderers = GetComponentsInChildren<Renderer>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Drop Zone")) {
            DestroyRod();
        }

        if (other.gameObject.CompareTag("Shark")) {
            DestroyRod();
            Debug.Log("Shark found");
        }
    }

    private void DestroyRod() {
        foreach (Renderer renderer in _rodRenderers) {
            renderer.enabled = false;
        }

        Invoke("RespawnRod", _respawnTime);
        _hasSpawned = false;
        Debug.Log("Rod destroyed");
    }

    private void RespawnRod() {
        if (_hasSpawned == false) {
            transform.position = _stand.position;
            transform.rotation = _stand.rotation;

            foreach (Renderer renderer in _rodRenderers) {
                renderer.enabled = true;
            }
            _hasSpawned = true;
            Debug.Log("Rod respawned");
        }
    }
}
