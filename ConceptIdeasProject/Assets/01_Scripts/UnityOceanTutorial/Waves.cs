using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Waves : MonoBehaviour {
    public int _dimension = 10;
    public float _uvScale;
    public Octave[] _octaves;

    protected MeshFilter _meshFilter;
    protected Mesh _mesh;

    private void Start() {
        //Mesh setup
        _mesh = new Mesh();
        _mesh.name = gameObject.name;

        _mesh.vertices = GenerateVerts();
        _mesh.triangles = GenerateTries();
        _mesh.uv = GenerateUVs();
        _mesh.RecalculateBounds();
        _mesh.RecalculateNormals(); //Without this you can't see any shadows

        _meshFilter = gameObject.AddComponent<MeshFilter>();
        _meshFilter.mesh = _mesh;
    }

    public float GetHeight(Vector3 position) {
        // Scale factor and positionn in local space
        Vector3 scale = new Vector3(1 / transform.lossyScale.x, 0, 1 / transform.lossyScale.z);
        Vector3 localPos = Vector3.Scale((position - transform.position), scale);

        // Get edge points
        Vector3 p1 = new Vector3(Mathf.Floor(localPos.x), 0, Mathf.Floor(localPos.z));
        Vector3 p2 = new Vector3(Mathf.Floor(localPos.x), 0, Mathf.Floor(localPos.z));
        Vector3 p3 = new Vector3(Mathf.Ceil(localPos.x), 0, Mathf.Floor(localPos.z));
        Vector3 p4 = new Vector3(Mathf.Ceil(localPos.x), 0, Mathf.Floor(localPos.z));

        // Clamp if the position is outside the plane
        p1.x = Mathf.Clamp(p1.x, 0, _dimension);
        p1.z = Mathf.Clamp(p1.z, 0, _dimension);
        p2.x = Mathf.Clamp(p2.x, 0, _dimension);
        p2.z = Mathf.Clamp(p2.z, 0, _dimension);
        p3.x = Mathf.Clamp(p3.x, 0, _dimension);
        p3.z = Mathf.Clamp(p3.z, 0, _dimension);
        p4.x = Mathf.Clamp(p4.x, 0, _dimension);
        p4.z = Mathf.Clamp(p4.z, 0, _dimension);

        // Get the max distance to one of the edges and take that to compute maz - dist
        float max = Mathf.Max(Vector3.Distance(p1, localPos), Vector3.Distance(p2, localPos), Vector3.Distance(p3, localPos), Vector3.Distance(p4, localPos) + Mathf.Epsilon);
        float dist = (max - Vector3.Distance(p1, localPos))
            + (max - Vector3.Distance(p2, localPos))
            + (max - Vector3.Distance(p3, localPos))
            + (max - Vector3.Distance(p4, localPos) + Mathf.Epsilon);

        // Weighted sum
        float height = _mesh.vertices[index(p1.x, p1.z)].y * (max - Vector3.Distance(p1, localPos))
            + _mesh.vertices[index(p2.x, p2.z)].y * (max - Vector3.Distance(p2, localPos))
            + _mesh.vertices[index(p3.x, p3.z)].y * (max - Vector3.Distance(p3, localPos))
            + _mesh.vertices[index(p4.x, p4.z)].y * (max - Vector3.Distance(p4, localPos));

        // Scale
        return height * transform.lossyScale.y / dist;
    }

    private int index(float x, float z) {
        // Function exist to get rid of the cannot convert float to int error message
        throw new NotImplementedException();
    }

    private Vector3[] GenerateVerts() {
        Vector3[] verts = new Vector3[(_dimension + 1) * (_dimension + 1)];

        // Equally distributed verts
        for (int x = 0; x <= _dimension; x++) {
            for (int z = 0; z <= _dimension; z++) {
                verts[index(x, z)] = new Vector3(x, 0, z);
            }
        }

        return verts;
    }

    private int index(int x, int z) {
        return (x * (_dimension + 1)) + z;
    }

    private int[] GenerateTries() {
        int[] tries = new int[_mesh.vertices.Length * 6];

        // Two triangles are one tile
        for (int x = 0; x < _dimension; x++) {
            for (int z = 0; z < _dimension; z++) {
                tries[index(x, z) * 6 + 0] = index(x, z);
                tries[index(x, z) * 6 + 1] = index(x + 1, z + 1);
                tries[index(x, z) * 6 + 2] = index(x + 1, z);
                tries[index(x, z) * 6 + 3] = index(x, z);
                tries[index(x, z) * 6 + 4] = index(x, z + 1);
                tries[index(x, z) * 6 + 5] = index(x + 1, z + 1);
            }
        }

        return tries;
    }

    private Vector2[] GenerateUVs() {
        Vector2[] uvs = new Vector2[_mesh.vertices.Length];

        //Always set one uv over the n tiles flip the uv and set it again
        for (int x = 0; x <= _dimension; x++) {
            for (int z = 0; z <= _dimension; z++) {
                var vec = new Vector2((x / _uvScale) % 2, (z / _uvScale) % 2);
                uvs[index(x, z)] = new Vector2(vec.x <= 1 ? vec.x : 2 - vec.x, vec.y <= 1 ? vec.y : 2 - vec.y);
            }
        }

        return uvs;
    }

    private void Update() {
        Vector3[] verts = _mesh.vertices;
        for (int x = 0; x <= _dimension; x++) {
            for (int z = 0; z <= _dimension; z++) {
                float y = 0f;
                for (int o = 0; o < _octaves.Length; o++) {
                    if (_octaves[o]._alternate) {
                        float perl = Mathf.PerlinNoise((x * _octaves[o]._scale.x) / _dimension, (z * _octaves[o]._scale.y) / _dimension) * Mathf.PI * 2f;
                        y += Mathf.Cos(perl + _octaves[o]._speed.magnitude * Time.time) * _octaves[o]._height;
                    }
                    else {
                        var perl = Mathf.PerlinNoise((x * _octaves[o]._scale.x + Time.time * _octaves[o]._speed.x) / _dimension, (z * _octaves[o]._scale.y + Time.time * _octaves[o]._speed.y) / _dimension) - 0.5f;
                        y += perl * _octaves[o]._height;
                    }
                }
                verts[index(x, z)] = new Vector3(x, y, z);
            }
        }
        _mesh.vertices = verts;
        _mesh.RecalculateNormals();
    }

    [Serializable]
    public struct Octave {
        public Vector2 _speed;
        public Vector2 _scale;
        public float _height;
        public bool _alternate;
    }
}
