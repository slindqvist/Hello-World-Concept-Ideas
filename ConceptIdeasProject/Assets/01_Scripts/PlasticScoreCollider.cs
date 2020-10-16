using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticScoreCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Plastic")) {
            //Set score +10p
        }
    }
}
