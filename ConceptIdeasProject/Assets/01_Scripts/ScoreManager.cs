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
    public bool _firstLevelComplete = false;
    public bool _secondLevelComplete = false;

    private float _score = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _plasticManager = FindObjectOfType<PlasticWasteManager>();
        _metalManager = FindObjectOfType<MetalWasteManager>();
        _electronicManager = FindObjectOfType<ElectronicWasteManager>();

        _firstLevelComplete = false;
        _secondLevelComplete = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(_plasticManager._plasticCount == _score) {
            if (_metalManager._metalCount == _score) {
                if (_electronicManager._electronicCount == _score) {
                    _plasticBinFullTxt.text = "OK";
                    _metalBinFullTxt.text = "OK";
                    _electronicBinFullTxt.text = "OK";
                    _firstLevelComplete = true;
                    Debug.Log("Level 1 Complete");
                }
            }
        }

        if (_plasticManager._plasticCount == _score && !_firstLevelComplete) {
            if (_metalManager._metalCount == _score) {
                if (_electronicManager._electronicCount == _score) {
                    _plasticBinFullTxt.text = "OK";
                    _metalBinFullTxt.text = "OK";
                    _electronicBinFullTxt.text = "OK";
                    _secondLevelComplete = true;
                    Debug.Log("Level 2 Complete");
                }
            }
        }
    }
}
