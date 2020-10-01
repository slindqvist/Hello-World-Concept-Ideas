using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål07 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube07;
    public GameObject _collider07;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mål07")
        {
            _cube07.material.color = _changeToMaterial.color;
            _collider07.SetActive(false);
            
            if (_cubeOnRightPlace != null)
            {
                _cubeOnRightPlace.Invoke();
            }
        }
    }
}
           



