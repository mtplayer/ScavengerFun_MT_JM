using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;
    public ButtonHandler buttonHandler;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        //buttonHandler = GetComponent<ButtonHandler>();
    }

    private void Update()
    {
        
    }

    public void IncreaseScore()
    {
        //if (buttonHandler.GetItemsFound())
        //{

        //}


        /*
        psudocode
        
        score = 0 at beginning of game

        currentScore = timeLeft(whenItemIsClicked) + score
        currentScore = levelScore


        */
    }
}
