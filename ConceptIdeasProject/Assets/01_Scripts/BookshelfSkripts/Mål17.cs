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
    public GameObject _light17;

    public Transform _transformCube17;
    public Transform _respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (_light17.activeSelf)
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

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube17.transform.position = _respawnPoint.transform.position;

        }
    }
}



            
