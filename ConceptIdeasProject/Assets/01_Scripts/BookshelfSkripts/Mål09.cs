using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål09 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube09;
    public GameObject _collider09;
    public GameObject _light09;

    public Transform _transformCube09;
    public Transform _respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (_light09.activeSelf)
        {
            if (other.gameObject.tag == "Mål09")
            {
                _cube09.material.color = _changeToMaterial.color;
                _collider09.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube09.transform.position = _respawnPoint.transform.position;

        }
    }
}



           
