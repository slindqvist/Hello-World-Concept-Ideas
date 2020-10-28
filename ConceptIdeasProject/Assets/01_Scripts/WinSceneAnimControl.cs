using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSceneAnimControl : MonoBehaviour
{
    private Animator _icePlatformAnimator;

    void Start()
    {
        _icePlatformAnimator = GetComponent<Animator>();
        _icePlatformAnimator.SetBool("HasWon", false);
    }

    [ContextMenu("YouHaveWon")]
    public void PlayWinScene() {
        _icePlatformAnimator.SetBool("HasWon", true);
    }
}
