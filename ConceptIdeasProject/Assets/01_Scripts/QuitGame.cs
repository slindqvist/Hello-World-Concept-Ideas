using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class QuitGame : MonoBehaviour
{
    const string _clearWebURL = "http://dreamlo.com/lb/Bnh5F_gCikq52sWu6dBb-wgeQxiAC_ske6vpn5_YjjAA/clear";

    private void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            StartCoroutine(ClearCleanWaterHighscores(_clearWebURL));
        }

        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
    }

    private IEnumerator ClearCleanWaterHighscores(string uri) {
        using (UnityWebRequest www = UnityWebRequest.Get(uri)) {
            yield return www.SendWebRequest();
        }
    }
}
