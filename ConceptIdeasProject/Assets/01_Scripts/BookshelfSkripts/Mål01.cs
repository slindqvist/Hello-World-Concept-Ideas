using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål01 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube01;
    public GameObject _collider01;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mål01")
        {
            _cube01.material.color = _changeToMaterial.color;
            _collider01.SetActive(false);
            
            if (_cubeOnRightPlace != null)
            {
                _cubeOnRightPlace.Invoke();
            }
         }
    }
}
           


   
    

   









