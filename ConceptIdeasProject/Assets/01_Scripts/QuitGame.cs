using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    private void Update() {
        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
    }

    public void EndGame() {
        Application.Quit();
        Debug.Log("Quitting game");
    }
}
