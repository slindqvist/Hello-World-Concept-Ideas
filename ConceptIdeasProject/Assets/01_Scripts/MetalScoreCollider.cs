using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalScoreCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Metal")) {
            //Set score +10p
        }
    }
}
