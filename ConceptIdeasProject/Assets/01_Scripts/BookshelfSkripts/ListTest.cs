using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public List<GameObject> _lights = new List<GameObject>();
    private int _lightNumber;
    public void Start()
    {


        Shuffle(_lights);
        // _lightNumber = Random.Range(0, _lights.Count);
        _lights[_lightNumber].SetActive(true);


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomLights();
        }
    }

    public void RandomLights()
    {
        //_lightNumber = Random.Range(0, _lights.Count);

        for (int i = 0; i < _lights.Count; i--)
        {
            _lights[i].SetActive(false);
            _lights.RemoveAt(i);

            _lights[_lightNumber].SetActive(true);
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


