using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Animations;

public class PlasticWasteManager : MonoBehaviour {

    public TextMeshProUGUI _plasticText;
    public int _plasticCount;

    private Animator _plasticAnimator;

    //public GameObject _plastic;
    //public Transform _rod;
    //public Rigidbody _rigidbody;

    void Start() {
        _plasticText = GetComponentInChildren<TextMeshProUGUI>();
        _plasticAnimator = GetComponentInChildren<Animator>();

        _plasticCount = 3;

        SetPlasticCountText();

        _plasticAnimator.SetBool("IsFull", false);
    }

    private void Update() {
        if(_plasticCount == 0) {
            PlayPlasticAnim();
        }
    }

    public void SetPlasticCountText() {
        _plasticText.text = _plasticCount.ToString();
    }

    [ContextMenu("RecyclingFull")]
    public void PlayPlasticAnim() {
        _plasticAnimator.SetBool("IsFull", true);
    }

    //public void CollectPlasticWaste() {
    //    _plastic.transform.SetParent(_rod);
    //    _rigidbody.isKinematic = true;
    //    Debug.Log("Plastic collected");
    //}

    //public void PlasticDropZone() {
    //    _plastic.transform.SetParent(null);
    //    _rigidbody.isKinematic = false;
    //    Debug.Log("Plastic unparented");
    //}
}
