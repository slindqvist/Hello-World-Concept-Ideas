using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    private BookshelfHighscores _bookshelfHighscores;

    public List<GameObject> _floorPlateList = new List<GameObject>();
    public GameObject _lastFloorPlate;
    public GameObject _bokShelf;
    public Animator _floorAnimation;

    public float _totalTime;
    private float _minutes;
    private float _seconds;

    public Text _timerText;
    public Text _gameOverText;

    public GameObject _placeHolder;
    public float waitTime = 10f;

    public AudioSource _tickingSound;
    
    public void Start() 
    {
        _bookshelfHighscores = FindObjectOfType<BookshelfHighscores>();

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

        if (_minutes == 0 && _seconds == 20) 
        {
            if (!_tickingSound.isPlaying) 
            {
                _tickingSound.Play();
            }
            
            _timerText.color = Color.red;
        }

        if (_minutes == 0 && _seconds == 0) 
        {

            _timerText.enabled = false;
            _gameOverText.enabled = true;
            
            _lastFloorPlate.GetComponent<Rigidbody>().isKinematic = false;
            _bokShelf.GetComponent<MeshCollider>().convex = true;
            _bokShelf.GetComponent<Rigidbody>().isKinematic = false;
            _bokShelf.GetComponent<Rigidbody>().useGravity = true;
            
            StartCoroutine("GameOverCoroutine");
        }
    }
    public IEnumerator FloorPanelOff() 
    {
        for (int i = 0; i < _floorPlateList.Count; i--) 
        {
            
            yield return new WaitForSeconds(10f);
            Debug.Log("Play Animation" + _floorPlateList[i].ToString());
            
            _floorPlateList[i].GetComponent<AudioSource>().Play();

            Quaternion startRotation = _floorPlateList[i].transform.rotation;
            Quaternion endRotation = Quaternion.Euler(15, 0, 15) * startRotation;

            float counter = 0f;
            while (counter < 1f)
            {
                counter += Time.deltaTime / 5f;
                _floorPlateList[i].transform.rotation = Quaternion.Lerp(startRotation, endRotation, counter);
                yield return null;
            }
            
            _floorPlateList[i].transform.rotation = endRotation;
          
            yield return new WaitForSeconds(0f);
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
        while (n > 1) {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public IEnumerator GameOverCoroutine() 
    {

        yield return new WaitForSeconds(waitTime);
        _placeHolder.SetActive(true);
        Debug.Log("Returning to start scene...");
    }
}


    



               
            

            
         












