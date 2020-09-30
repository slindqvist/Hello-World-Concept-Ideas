using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteMover : MonoBehaviour
{
    public Transform _motor;
    public float _power = 1f;

    protected Rigidbody _moverRigidbody;
    protected Quaternion _startRotation;

    private void Awake() {
        _moverRigidbody = GetComponent<Rigidbody>();
        _startRotation = _motor.localRotation;
    }

    private void FixedUpdate() {
        Vector3 forceDirection = transform.forward;
        int steer = 1;

        _moverRigidbody.AddForceAtPosition(steer * transform.forward * _power, _motor.position);
    }
}
