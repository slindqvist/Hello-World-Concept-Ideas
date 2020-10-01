using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål03 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube03;
    public GameObject _collider03;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mål03")
        {
            _cube03.material.color = _changeToMaterial.color;
            _collider03.SetActive(false);
            
            if (_cubeOnRightPlace != null)
            {
                _cubeOnRightPlace.Invoke();
            }
        }
    }
}



           
