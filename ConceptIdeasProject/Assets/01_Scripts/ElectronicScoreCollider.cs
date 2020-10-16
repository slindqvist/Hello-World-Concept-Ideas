using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronicScoreCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Electronic")) {
            //Set score +10p
        }
    }
}
