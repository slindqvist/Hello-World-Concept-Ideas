using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål15 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube15;
    public GameObject _collider15;
    public GameObject _light15;

    public Transform _transformCube15;
    public Transform _respawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        if (_light15.activeSelf)
        {
            if (other.gameObject.tag == "Mål15")
            {
                _cube15.material.color = _changeToMaterial.color;
                _collider15.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube15.transform.position = _respawnPoint.transform.position;

        }
    }
}



           
