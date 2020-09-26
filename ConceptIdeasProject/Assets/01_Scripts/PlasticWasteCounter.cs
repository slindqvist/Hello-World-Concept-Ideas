using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlasticWasteCounter : MonoBehaviour
{
    public Text _plasticWasteCountText;

    private int _count;

    void Start()
    {
        _count = 4;
        SetCountText();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Plastic")) {
            Debug.Log("Plastic recycled");
            other.gameObject.SetActive(false);

            _count = _count - 1;

            SetCountText();

        }
    }

    private void SetCountText() {
        _plasticWasteCountText.text = _count.ToString();
    }
}
