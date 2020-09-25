using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeOnRightPlace : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    

    private void OnTriggerEnter(Collider other)
    {


        
        
        if (_cubeOnRightPlace != null)
        {
            _cubeOnRightPlace.Invoke();
        }
    }
}
