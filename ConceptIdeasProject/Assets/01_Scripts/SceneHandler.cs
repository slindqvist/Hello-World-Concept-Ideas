using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using Valve.VR.Extras;

public class SceneHandler : MonoBehaviour
{
    public SteamVR_LaserPointer _laserPointer;

    public GameObject _rensaVattnetPlaceHolder;

    private void Awake() {
        _laserPointer.PointerIn += PointerInside;
        _laserPointer.PointerOut += PointerOutside;
        _laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e) {
        if (e.target.name == "RensaVattnet") {
            _rensaVattnetPlaceHolder.SetActive(true);
            Debug.Log("Rensa vattnet was clicked");
        }
        else if (e.target.name == "Bokhyllan") {
            Debug.Log("Bokhyllan was clicked");
        }
    }

    public void PointerInside(object sender, PointerEventArgs e) {
        if (e.target.name == "RensaVattnet") {
            Debug.Log("Rensa vattnet was entered");
        }
        else if (e.target.name == "Bokhyllan") {
            Debug.Log("Bokhyllan was entered");
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e) {
        if (e.target.name == "RensaVattnet") {
            Debug.Log("Rensa vattnet was exited");
        }
        else if (e.target.name == "Bokhyllan") {
            Debug.Log("Bokhyllan was exited");
        }
    }
}
