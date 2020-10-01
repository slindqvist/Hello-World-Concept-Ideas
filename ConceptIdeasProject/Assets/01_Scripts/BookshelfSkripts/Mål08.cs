using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål08 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube08;
    public GameObject _collider08;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mål08")
        {
            _cube08.material.color = _changeToMaterial.color;
            _collider08.SetActive(false);
           
            if (_cubeOnRightPlace != null)
            {
                _cubeOnRightPlace.Invoke();
            }
        }
    }
}



           
