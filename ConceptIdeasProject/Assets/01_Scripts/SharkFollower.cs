using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkFollower : MonoBehaviour {
    [SerializeField] Transform _fishingRod;
    [SerializeField] float _chaseSpeed = 10f;
    [SerializeField] float _rotateSpeed = 10f;

    public GameObject[] _waypoints;
    public float _moveSpeed;
    int _currentIndex = 0;
    float _waypointRadius = 1f;


    private void Start() {

    }

    void Update() {
        if (_fishingRod.transform.position.y <= 0) {
            Follow();
        }
        else {
            Swim();
        }
    }

    private void Follow() {
            transform.position += transform.forward * Time.deltaTime * _chaseSpeed;
            Vector3 rodDirection = _fishingRod.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(rodDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, Time.deltaTime * _rotateSpeed);
            Debug.Log("Chasing rod");
    }

    private void Swim() {
        if (Vector3.Distance(_waypoints[_currentIndex].transform.position, transform.position) < _waypointRadius) {
            _currentIndex++;
            if (_currentIndex >= _waypoints.Length) {
                _currentIndex = 0;
            }
        }

        Vector3 pointDirection = _waypoints[_currentIndex].transform.position + transform.position;
        Quaternion pointRotation = Quaternion.LookRotation(pointDirection);

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentIndex].transform.position, Time.deltaTime * _moveSpeed);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, pointRotation, Time.deltaTime * _rotateSpeed);
    }
}
