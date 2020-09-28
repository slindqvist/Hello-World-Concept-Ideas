using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private PlasticWasteManager _plasticManager;
    private MetalWasteManager _metalManager;
    private ElectronicWasteManager _electronicManager;

    public Text _plasticBinFullTxt, _metalBinFullTxt, _electronicBinFullTxt;
    public bool _levelOneComplete = false;

    private float _score = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _plasticManager = FindObjectOfType<PlasticWasteManager>();
        _metalManager = FindObjectOfType<MetalWasteManager>();
        _electronicManager = FindObjectOfType<ElectronicWasteManager>();
    }

    // Update is called once per frame
    void Update()
    {
        while (_levelOneComplete) {

        }

        if(_plasticManager._plasticCount == _score) {
            _plasticBinFullTxt.text = "OK";
            Debug.Log("Plastic bin full");
        }

        if (_metalManager._metalCount == _score) {
            _metalBinFullTxt.text = "OK";
            Debug.Log("Metal bin full");
        }

        if (_electronicManager._electronicCount == _score) {
            _electronicBinFullTxt.text = "OK";
            Debug.Log("Electronic bin full");
        }
    }
}
