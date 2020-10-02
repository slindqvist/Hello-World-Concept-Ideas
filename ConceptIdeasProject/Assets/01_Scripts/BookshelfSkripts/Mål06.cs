using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål06 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube06;
    public GameObject _collider06;
    public GameObject _light06;
    
    private void OnTriggerEnter(Collider other)
    {
        if (_light06.activeSelf)
        {
            if (other.gameObject.tag == "Mål06")
            {
                _cube06.material.color = _changeToMaterial.color;
                _collider06.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }
    }
}




