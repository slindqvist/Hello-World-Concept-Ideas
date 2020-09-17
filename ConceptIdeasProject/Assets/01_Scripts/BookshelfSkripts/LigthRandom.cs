using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthRandom : MonoBehaviour
{
      public GameObject[] _lights;
      private int _lightNumber; 
      //public List<GameObject> _lightsList = new List<GameObject>();

    public void Start()
    {
        _lightNumber = Random.Range(0, _lights.Length);
        for (int i = 0; i < _lights.Length; i++)
            //_lights[i].SetActive(false);
            _lights[_lightNumber].SetActive(true);

        /* for (int i = 0; i < _lightsList.Count; i++) 
         {
             int j = Random.Range(i, _lightsList.Count);
             GameObject t = _lightsList[i];
             _lightsList[i] = _lightsList[j];
             _lightsList[j] = t;
             _lightsList[i].SetActive(false);
         } */
    }

    public void Update()
    {
       

            

           /* for (int k = 0; k < _lightsList.Count; k++)
            {
                _lightsList[k].SetActive(false);

                

                
            }*/
         
    }

    public void RandomLights()
    {
        _lightNumber = Random.Range(0, _lights.Length);

        for (int i = 0; i < _lights.Length; i++)
        {
            _lights[i].SetActive(false);


            _lights[_lightNumber].SetActive(true);
        }

    }


}
