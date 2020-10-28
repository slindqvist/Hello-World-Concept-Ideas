using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål11 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube11;
    public GameObject _collider11;
    public GameObject _light11;

    public Transform _transformCube11;
    public Transform _respawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        if (_light11.activeSelf)
        {
            if (other.gameObject.tag == "Mål11")
            {
                _cube11.material.color = _changeToMaterial.color;
                _collider11.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube11.transform.position = _respawnPoint.transform.position;

        }
    }
}



          
