using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål13 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube13;
    public GameObject _collider13;
    public GameObject _light13;

    public Transform _transformCube13;
    public Transform _respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (_light13.activeSelf)
        {
            if (other.gameObject.tag == "Mål13")
            {
                _cube13.material.color = _changeToMaterial.color;
                _collider13.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube13.transform.position = _respawnPoint.transform.position;

        }
    }
}

           


