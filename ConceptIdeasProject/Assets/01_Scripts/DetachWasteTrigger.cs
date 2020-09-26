using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DetachWasteTrigger : MonoBehaviour {

    public UnityEvent OnCollectingWasteEnd;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Waste") {
            OnCollectingWasteEnd.Invoke();
            Debug.Log("Detach trigger");
        }
    }
}
