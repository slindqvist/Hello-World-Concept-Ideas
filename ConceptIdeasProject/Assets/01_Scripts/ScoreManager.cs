using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private PlasticWasteManager _plasticManager;
    private MetalWasteManager _metalManager;
    private ElectronicWasteManager _electronicManager;
    
    public bool _firstLevelComplete = false;

    private float _score = 0f;
    
    void Start()
    {
        _plasticManager = FindObjectOfType<PlasticWasteManager>();
        _metalManager = FindObjectOfType<MetalWasteManager>();
        _electronicManager = FindObjectOfType<ElectronicWasteManager>();
    }
    
    void FixedUpdate()
    {
        if(_plasticManager._plasticCount == _score) {
            if (_metalManager._metalCount == _score) {
                if (_electronicManager._electronicCount == _score) {
                    // Animate lids to close
                    _plasticManager.PlayPlasticAnim();
                    _metalManager.PlayMetalAnim();
                    _electronicManager.PlayElectronicAnim();

                    _firstLevelComplete = true;
                    Debug.Log("Level 1 Complete");
                }
            }
        }
    }
}
