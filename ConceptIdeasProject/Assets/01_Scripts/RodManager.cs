using UnityEngine;

public class RodManager : MonoBehaviour
{
    public GameObject _fishingRod;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Drop Zone")){
            //Respawn rod
        }
    }
}
