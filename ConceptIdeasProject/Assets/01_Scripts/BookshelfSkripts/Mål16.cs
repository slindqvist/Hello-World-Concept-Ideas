using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål16 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube16;
    public GameObject _collider16;
    public GameObject _light16;
    public GameObject _image16;
    public AudioSource _scoreSound;
    public AudioSource _knaggleSound;

    public Transform _transformCube16;
    public Transform _respawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        if (_light16.activeSelf)
        {
            if (other.gameObject.tag == "Mål16")
            {
                if (!_scoreSound.isPlaying)
                {
                    _scoreSound.Play();
                }

                _cube16.material.color = _changeToMaterial.color;
                _collider16.SetActive(false);
                _image16.SetActive(true);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube16.transform.position = _respawnPoint.transform.position;
           
            if (!_knaggleSound.isPlaying)
            {
                _knaggleSound.Play();
            }
        }
    }
}



           
