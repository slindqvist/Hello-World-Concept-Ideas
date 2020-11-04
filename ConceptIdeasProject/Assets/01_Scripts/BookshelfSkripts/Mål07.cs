using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mål07 : MonoBehaviour
{
    public UnityEvent _cubeOnRightPlace;
    public Material _changeToMaterial;
    public Renderer _cube07;
    public GameObject _collider07;
    public GameObject _light07;
    public GameObject _image07;
    public AudioSource _scoreSound;
    public AudioSource _knaggleSound;

    public Transform _transformCube07;
    public Transform _respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (_light07.activeSelf)
        {
            if (other.gameObject.tag == "Mål07")
            {

                if (!_scoreSound.isPlaying)
                {
                    _scoreSound.Play();
                }

                _cube07.material.color = _changeToMaterial.color;
                _collider07.SetActive(false);
                _image07.SetActive(true);

                Score._score += 10;

                if (_cubeOnRightPlace != null)
                {
                    _cubeOnRightPlace.Invoke();
                }
            }
        }

        if (other.CompareTag("RespawnArea"))
        {
            _transformCube07.transform.position = _respawnPoint.transform.position;

            if (!_knaggleSound.isPlaying)
            {
                _knaggleSound.Play();
            }

        }
    }
}
           



