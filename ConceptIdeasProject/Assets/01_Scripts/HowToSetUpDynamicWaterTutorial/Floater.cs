using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody _rigidBody;
    public float _depthBeforeSubmerged = 1f;
    public float _displacementAmount = 3f;
    public int _floaterCount = 1;
    public float _waterDrag = 0.99f;
    public float _waterAngularDrag = 0.5f;

    private void FixedUpdate() {
        _rigidBody.AddForceAtPosition(Physics.gravity / _floaterCount, transform.position, ForceMode.Acceleration);
        float waveHeight = WaveManager.instance.GetWaveHeight(transform.position.x);

        if(transform.position.y < waveHeight) {
            float displacementMultiplier = Mathf.Clamp01((waveHeight -transform.position.y) / _depthBeforeSubmerged) * _displacementAmount;
            _rigidBody.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), transform.position, ForceMode.Acceleration);
            _rigidBody.AddForce(displacementMultiplier * -_rigidBody.velocity * _waterDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
            _rigidBody.AddTorque(displacementMultiplier * -_rigidBody.angularVelocity * _waterAngularDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }
}
