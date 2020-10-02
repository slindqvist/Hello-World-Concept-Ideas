using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål14 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube14;
    public GameObject _collider14;
    public GameObject _light14;

    private void OnTriggerEnter(Collider other)
    {
        if (_light14.activeSelf)
        {
            if (other.gameObject.tag == "Mål14")
            {
                _cube14.material.color = _changeToMaterial.color;
                _collider14.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }
    }
}

           


