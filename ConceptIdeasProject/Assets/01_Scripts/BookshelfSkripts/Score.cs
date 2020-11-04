using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int _score = 0;

    public Text _scoreText;

    public void Update()
    {
        _scoreText.text = _score.ToString();
    }
}
