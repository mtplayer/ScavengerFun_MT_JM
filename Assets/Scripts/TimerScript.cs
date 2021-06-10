using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public static bool timerActive = true;//
    public bool canMoveTime = true;

    public int maxTime;
    public int currentTime;

    private TextMeshProUGUI timerText;
    private SceneChanger sceneChanger;//

    private void Start()
    {
        sceneChanger = FindObjectOfType<SceneChanger>();
        timerText = GetComponent<TextMeshProUGUI>();

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
            SceneChanger.instance.LoadMainMenu();
            currentTime = maxTime;
        }
    }
}