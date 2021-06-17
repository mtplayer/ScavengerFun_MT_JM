using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int itemsFound = 0;
    
    public int level = 0;

    private TextMeshProUGUI scoreText;
    private SceneChanger sceneChanger;
    public CanvasGroup canvasGroup;

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;

    public TextMeshProUGUI finalScoreText;

    public float score = 0;
    public float displayScore;
    public float scoreUpdateTime = 0.02f;
    public int scoreRounded = 0;

    private void Start()
    {
        //DontDestroyOnLoad(gameObject);

        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        scoreText = GetComponent<TextMeshProUGUI>();
        sceneChanger = FindObjectOfType<SceneChanger>();
        canvasGroup = GetComponentInParent<CanvasGroup>();
    }

    public void SetUIHeaderOn()
    {
        canvasGroup.alpha = 1;
    }

    public void SetUIHeaderOff()
    {
        canvasGroup.alpha = 0;
    }
  
    private void Update()//TODO
    {
        scoreText.text = itemsFound.ToString();

        //if (itemsFound == 0 && level == 0)
        //{
        //    button1.interactable = true;
        //    image1.raycastTarget = true;
        //    button2.interactable = false;
        //    image2.raycastTarget = false;
        //    button3.interactable = false;
        //    image3.raycastTarget = false;
        //    button4.interactable = false;
        //    image4.raycastTarget = false;
        //    score = 0;
        //}

        if (itemsFound > 5 && level == 1)
        {
            button1.interactable = false;
            image1.raycastTarget = false;
            button2.interactable = true;
            image2.raycastTarget = true;
            score = score + (5 * global::TimerManager.instance.CurrentTime);
            StartCoroutine(ScoreUpdated());
            sceneChanger.LoadMainMenu();
        }
        
        if (itemsFound > 9 && level == 2)
        {
            button2.interactable = false;
            image2.raycastTarget = false;
            button3.interactable = true;
            image3.raycastTarget = true;
            //score += itemsFound;
            //finalScoreText.text = "Score: " + score.ToString();
            score = score + (5 * global::TimerManager.instance.CurrentTime);
            StartCoroutine(ScoreUpdated());
            sceneChanger.LoadMainMenu();
        }

        if (itemsFound > 13 && level == 3)
        {
            button3.interactable = false;
            image3.raycastTarget = false;
            button4.interactable = true;
            image4.raycastTarget = true;
            //score += itemsFound;
            //finalScoreText.text = "Score: " + score.ToString();
            score = score + (5 * global::TimerManager.instance.CurrentTime);
            StartCoroutine(ScoreUpdated());
            sceneChanger.LoadMainMenu();
        }

        if (itemsFound > 15 && level == 4)
        {
            button4.interactable = false;
            image4.raycastTarget = false;
            //score += itemsFound;
            //finalScoreText.text = "Score: " + score.ToString();
            score = score + (5 * global::TimerManager.instance.CurrentTime);
            StartCoroutine(ScoreUpdated());
            sceneChanger.LoadMainMenu();
        }
    }

    private IEnumerator ScoreUpdated()
    {
        while (true)
        {
            if (displayScore < score)
            {
                displayScore++;

                scoreRounded = (int)Math.Floor(displayScore);
                //scoreTxt.text = scoreRounded.ToString("0");
                finalScoreText.text = "Score: " + scoreRounded.ToString("0");
            }

            yield return new WaitForSeconds(scoreUpdateTime);
        }
    }
}