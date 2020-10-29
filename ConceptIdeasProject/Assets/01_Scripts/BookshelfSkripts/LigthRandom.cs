﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class LigthRandom : MonoBehaviour
{
   
    
    public List<GameObject> _lightsList = new List<GameObject>();
    private int _lightNumber;
    
   // public GameObject _lastLight;
   // public GameObject _logoCube;

   
    
    
    public void Start()
    {
        Shuffle(_lightsList);
        
        
        _lightsList[_lightNumber].SetActive(true);
       // _lastLight.SetActive(false);
       // _logoCube.SetActive(false);
    }

    public void Update()
    {
        if (_lightsList.Count == 0)
        {
           // _lastLight.SetActive(true);
           // _logoCube.SetActive(true);

           // Fyverkerier och du har vunnit :) 
        }
       
    }
    
    
  
    
    public void RandomLights()
    {
        for (int i = 0; i < _lightsList.Count; i--)
        {
            
            _lightsList[i].SetActive(false);
            _lightsList.RemoveAt(i);

            _lightsList[_lightNumber].SetActive(true);
        }
    }

   
    public void Shuffle<T>(IList<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
       
    
       





            
           

   
