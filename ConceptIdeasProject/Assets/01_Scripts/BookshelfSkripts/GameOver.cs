using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    Timer _timer;

    public void Start()
    {
        _timer = FindObjectOfType<Timer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _timer.StartCoroutine("GameOverCoroutine");
            Debug.Log("GameOver");
        } 
    }
}
