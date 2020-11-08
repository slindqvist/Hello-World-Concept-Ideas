﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class LigthRandom : MonoBehaviour
{
    Score _scoreManager;
    Timer _timerManager;
    
    public List<GameObject> _lightsList = new List<GameObject>();
    private int _lightNumber;

    public Text _countText;
    
    public void Start()
    {
        _scoreManager = FindObjectOfType<Score>();
        _timerManager = FindObjectOfType<Timer>();

        Shuffle(_lightsList);
        
        _lightsList[_lightNumber].SetActive(true);
    }
        
    public void Update()
    {
        if (_lightsList.Count == 0)
        {

            _scoreManager.AssigBonusPoints();
            _timerManager.StartCoroutine("GameOverCoroutine");
           // Fyverkerier och du har vunnit :) 
        }

        Counting();
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

    public void Counting()
    {
        _countText.text = _lightsList.Count.ToString();
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
       
       
        
       
       

    
  
   

   
    
    
    

   
    
       





            
           

   

