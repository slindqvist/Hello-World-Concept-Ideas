using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål05 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube05;
    public GameObject _collider05;
    public GameObject _light05;

    private void OnTriggerEnter(Collider other)
    {
        if (_light05.activeSelf)
        {
            if (other.gameObject.tag == "Mål05")
            {
                _cube05.material.color = _changeToMaterial.color;
                _collider05.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }
    }
}


          

