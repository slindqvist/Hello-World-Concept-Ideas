using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål10 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube10;
    public GameObject _collider10;
    public GameObject _light10;

    private void OnTriggerEnter(Collider other)
    {
        if (_light10.activeSelf)
        {
            if (other.gameObject.tag == "Mål10")
            {
                _cube10.material.color = _changeToMaterial.color;
                _collider10.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }
    }
}


          

