using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectingWasteTrigger : MonoBehaviour
{
    public UnityEvent OnCollectingWasteStart;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Waste") {
            OnCollectingWasteStart.Invoke();
            Debug.Log("Waste trigger entered");
        }
    }
}
