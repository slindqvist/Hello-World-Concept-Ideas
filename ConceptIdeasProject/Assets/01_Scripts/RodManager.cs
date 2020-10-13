using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodManager : MonoBehaviour
{
    public GameObject _fishingRod;
    public Transform _rodStand;

    private void Start() {

    }

    private void PlaceInStand() {
        //GameObject instantiatedRod = Instantiate(_fishingRod);
        //instantiatedRod.transform.SetParent(_rodStand);
    }

    public void RespawnRod() {
        //Instantiate(_fishingRod, _rodStand.position, _rodStand.rotation);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Rod")){
            //PlaceInStand();
            //Debug.Log("Rod placed in stand");
        }
    }
}
