using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål03 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Mål03")


            if (_cubeOnRightPlace != null)
            {
                _cubeOnRightPlace.Invoke();
            }
    }
}
