using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public static TimerManager instance;

    private float currentTime;
    //public float maxTime = 30;

    private TextMeshProUGUI timerText;

    public bool timerActive = false;

    public float CurrentTime { get => currentTime; set => currentTime = value; }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        timerText = GetComponent<TextMeshProUGUI>();
        //timerText.text = maxTime.ToString();
        //currentTime = maxTime;
    }

    private void Update()
    {
        Timer();
    }

    public void Timer()
    {
        if (timerActive)
        {
            currentTime -= 1 * Time.deltaTime;
            //UIManager.instance.CountdownTxt.text = CurrentTime.ToString("0");
            timerText.text = currentTime.ToString("0");
        }
        

        if (timerActive && currentTime <= 0)
        {
            currentTime = 0;
            timerActive = false;
            //UIManager.instance.DeactivatePuzzle();
            //LevelLoaderManager.instance.LoadNextEndLevel();
            //currentTime = maxTime;
            SceneChanger.instance.LoadMainMenu();
        }
    }
}
