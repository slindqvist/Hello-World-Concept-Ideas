using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public Transform[] _secondLvlTargets;
    private int _secondLevelTargetIndex;

    public float _transportationTime = 5.0f;
    
    public void ActivateSecondLevel() {
        StartCoroutine(SecondLvlCoroutine(_secondLvlTargets[_secondLevelTargetIndex]));
        Debug.Log("Raise second platform");
    }

    public void ActivateThirdPlatform() {
        Debug.Log("Raise third platform");
    }

    private IEnumerator SecondLvlCoroutine(Transform target) {
        Debug.Log("Coroutine started");
        Vector3 startPos = transform.position;
        float lerper = 0;
        while (lerper < 1f) {
            lerper += Time.deltaTime / _transportationTime;
            transform.position = Vector3.Lerp(startPos, target.position, lerper);
            yield return 0;
        }
        _secondLevelTargetIndex++;
        if (_secondLevelTargetIndex == _secondLvlTargets.Length) {
            _secondLevelTargetIndex = 0;
        }
    }
}
