using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål02 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube02;
    public GameObject _collider02;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mål02")
        {
            _cube02.material.color = _changeToMaterial.color;
            _collider02.SetActive(false);
            
            if (_cubeOnRightPlace != null)
            {
                _cubeOnRightPlace.Invoke();
            }
        }
    }
}





          
