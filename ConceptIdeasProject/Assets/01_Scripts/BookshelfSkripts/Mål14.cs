﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål14 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube14;
    public GameObject _collider14;
    public GameObject _light14;
    public GameObject _image14;
    public AudioSource _scoreSound;
    public AudioSource _knaggleSound;

    public Transform _transformCube14;
    public Transform _respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (_light14.activeSelf)
        {
            if (other.gameObject.tag == "Mål14")
            {
                if (!_scoreSound.isPlaying)
                {
                    _scoreSound.Play();
                }

                _cube14.material.color = _changeToMaterial.color;
                _collider14.SetActive(false);
                _image14.SetActive(true);

                Score._score += 10;

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube14.transform.position = _respawnPoint.transform.position;

            if (!_knaggleSound.isPlaying)
            {
                _knaggleSound.Play();
            }

        }
    }
}

           


