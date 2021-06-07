using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public static bool timerActive = true;
    public int maxTime;
    public int numItems;
    public int currentTime;
    public static bool gameWon = false;
    public TextMeshProUGUI timerText;

    public bool canMoveTime = true;

    public SceneChanger sceneChanger;

    private void Start()
    {
        timerText.text =  maxTime.ToString();
        currentTime = maxTime;
    }

    private void FixedUpdate()
    {
        if (currentTime > 0 && !canMoveTime)
        {
            if (timerActive)
            {
                currentTime = (int)Mathf.Ceil(maxTime - Time.timeSinceLevelLoad);//////////////////
                timerText.text = currentTime.ToString();
            }
            else
            {
                timerText.text = "";
            }
        }

       if (currentTime <= 0)
        {
            sceneChanger.LoadMainMenu();
        }
    }
}