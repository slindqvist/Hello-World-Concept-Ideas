using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public List<GameObject> _floorPlateList = new List<GameObject>();
    public GameObject _lastFloorPlate;
    public GameObject _bokShelf;
    public Animation _floorAnimation;

    public float _totalTime;
    private float _minutes;
    private float _seconds;
    
    public Text _timerText;
    public Text _gameOverText;

    public void Start()
    {
        StartCoroutine(FloorPanelOff());
        Shuffle(_floorPlateList);
        _gameOverText.enabled = false;
    }

    public void Update()
    {
        CountDownTimer();
    }
       
    public void CountDownTimer()
    {
        _totalTime -= Time.deltaTime;

        _minutes = (int)(_totalTime / 60);
        _seconds = (int)(_totalTime % 60);

        _timerText.text = _minutes.ToString() + ":" + _seconds.ToString();

        if (_minutes == 0 && _seconds == 10)
        {
            _timerText.color = Color.red;
        }

        if (_minutes == 0 && _seconds == 0)
        {

            _timerText.enabled = false;
            _gameOverText.enabled = true;
           // _lastFloorPlate.SetActive(false);
            _lastFloorPlate.GetComponent<Rigidbody>().isKinematic = false;
            _bokShelf.GetComponent<Rigidbody>().isKinematic = false;
            _bokShelf.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    public IEnumerator FloorPanelOff()
    {

        for (int i = 0; i < _floorPlateList.Count; i--)
        {
            
            yield return new WaitForSeconds(15f);
            _floorPlateList[i].GetComponent<Rigidbody>().isKinematic = false;
            _floorPlateList[i].GetComponent<Rigidbody>().useGravity = true;
            _floorPlateList.RemoveAt(i);

            yield return StartCoroutine(FloorPanelOff());

        }
    }

   
    public void Shuffle<T>(IList<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}





        
        
