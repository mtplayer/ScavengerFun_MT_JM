using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public static bool timerActive = true;
    public int maxTime;
    public int numItems;
    public int currentTime;
    public static bool gameWon = false;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI winner;


    // Start is called before the first frame update
    void Start()
    {
        timerText.text =  maxTime.ToString();
        currentTime = maxTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timerActive)
        {
            currentTime = (int)Mathf.Ceil(maxTime - Time.timeSinceLevelLoad);
            timerText.text = currentTime.ToString();
        }
        else
        {
            timerText.text = "";
        }
        if (ItemInteraction.itemsFound == numItems)
        {
            gameWon = true;
        }
    }

}
