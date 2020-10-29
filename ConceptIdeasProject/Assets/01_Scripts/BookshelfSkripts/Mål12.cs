﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål12 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube12;
    public GameObject _collider12;
    public GameObject _light12;
    public GameObject _image12;
    public AudioSource _scoreSound;
    public AudioSource _knaggleSound;

    public Transform _transformCube12;
    public Transform _respawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        if (_light12.activeSelf)
        {
            if (other.gameObject.tag == "Mål12")
            {

                if (!_scoreSound.isPlaying)
                {
                    _scoreSound.Play();
                }

                _cube12.material.color = _changeToMaterial.color;
                _collider12.SetActive(false);
                _image12.SetActive(true);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube12.transform.position = _respawnPoint.transform.position;

            if (!_knaggleSound.isPlaying)
            {
                _knaggleSound.Play();
            }


        }
    }
}



           
