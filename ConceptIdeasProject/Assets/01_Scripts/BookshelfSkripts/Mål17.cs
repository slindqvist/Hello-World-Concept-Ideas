using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål17 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube17;
    public GameObject _collider17;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mål17")
        {
            _cube17.material.color = _changeToMaterial.color;
            _collider17.SetActive(false);
            
            if (_cubeOnRightPlace != null)
            {
                _cubeOnRightPlace.Invoke();
            }
        }
    }
}



            
