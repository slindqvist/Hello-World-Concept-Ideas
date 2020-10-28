using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SceneSwitch : MonoBehaviour
{
    public int _currentLevel = 0;

    public string[] _levelNames = new string[2] { "StartScene", "RensaVattnet" };

    static SceneSwitch _switch = null;

    private void Start() {
        if(_switch == null) {
            _switch = this;
        }
        else {
            Destroy(this.gameObject);
        }
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            _currentLevel = (_currentLevel + 1) % 2; // Next level
            SteamVR_LoadLevel.Begin(_levelNames[_currentLevel]);
        }
    }
}
