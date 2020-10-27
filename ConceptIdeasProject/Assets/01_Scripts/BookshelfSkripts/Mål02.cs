using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål02 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube02;
    public GameObject _collider02;
    public GameObject _light02;

    public Transform _transformCube02;
    public Transform _respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (_light02.activeSelf)
        {
            if (other.gameObject.tag == "Mål02")
            {
                _cube02.material.color = _changeToMaterial.color;
                _collider02.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube02.transform.position = _respawnPoint.transform.position;

        }
    }
}
        
       





          
