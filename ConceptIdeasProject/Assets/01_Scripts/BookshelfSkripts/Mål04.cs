using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål04 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube04;
    public GameObject _collider04;
    public GameObject _light04;

    public Transform _transformCube04;
    public Transform _respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (_light04.activeSelf)
        {
            if (other.gameObject.tag == "Mål04")
            {
                _cube04.material.color = _changeToMaterial.color;
                _collider04.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube04.transform.position = _respawnPoint.transform.position;

        }
    }
}




         
