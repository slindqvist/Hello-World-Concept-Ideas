using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class WaterManager : MonoBehaviour
{
    private MeshFilter _meshFilter;

    private void Awake() {
        _meshFilter = GetComponent<MeshFilter>();
    }

    private void Update() {
        Vector3[] _vertices = _meshFilter.mesh.vertices;
        for (int i = 0; i < _vertices.Length; i++) {
            _vertices[i].y = WaveManager.instance.GetWaveHeight(transform.position.x + _vertices[i].x);
        }

        _meshFilter.mesh.vertices = _vertices;
        _meshFilter.mesh.RecalculateNormals();
    }
}
