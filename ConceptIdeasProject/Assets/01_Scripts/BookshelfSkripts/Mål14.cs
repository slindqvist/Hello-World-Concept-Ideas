using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål14 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Mål14")


            if (_cubeOnRightPlace != null)
            {
                _cubeOnRightPlace.Invoke();
            }
    }
}
