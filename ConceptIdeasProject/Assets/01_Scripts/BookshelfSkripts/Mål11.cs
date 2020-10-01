using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål11 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube11;
    public GameObject _collider11;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mål11")
        {
            _cube11.material.color = _changeToMaterial.color;
            _collider11.SetActive(false);
            
            if (_cubeOnRightPlace != null)
            {
                _cubeOnRightPlace.Invoke();
            }
        }
    }
}



          
