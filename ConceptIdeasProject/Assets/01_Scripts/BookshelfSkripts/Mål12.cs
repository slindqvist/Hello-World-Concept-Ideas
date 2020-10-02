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

    private void OnTriggerEnter(Collider other)
    {
        if (_light12.activeSelf)
        {
            if (other.gameObject.tag == "Mål12")
            {
                _cube12.material.color = _changeToMaterial.color;
                _collider12.SetActive(false);

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }
    }
}



           
