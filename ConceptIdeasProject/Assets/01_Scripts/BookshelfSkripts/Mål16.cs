using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål16 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube16;
    public GameObject _collider16;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mål16")
        {
            _cube16.material.color = _changeToMaterial.color;
            _collider16.SetActive(false);
           
            if (_cubeOnRightPlace != null)
            {
                _cubeOnRightPlace.Invoke();
            }
        }
    }
}



           
