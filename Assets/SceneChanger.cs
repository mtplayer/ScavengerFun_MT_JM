using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    //Main to level 1
    public void mainToLevelOne()
    {
        TimerScript.timerActive = true;
        Time.timeScale = 1;
        ItemInteraction.itemsFound = 0;
        TimerScript.gameWon = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //Main to level 2
    public void mainToLevelTwo()
    {
        TimerScript.timerActive = true;
        Time.timeScale = 1;
        ItemInteraction.itemsFound = 0;
        TimerScript.gameWon = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Main to level 3
    public void mainToLevelThree()
    {
        TimerScript.timerActive = true;
        Time.timeScale = 1;
        ItemInteraction.itemsFound = 0;
        TimerScript.gameWon = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    //Main to level 4
    public void mainToLevelFour()
    {
        TimerScript.timerActive = true;
        Time.timeScale = 1;
        TimerScript.gameWon = false;
        ItemInteraction.itemsFound = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    //Main to Freestyle
    public void mainToFreestyle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    //Quit to desktop
    public void quit()
    {
        Application.Quit();
    }

    //--------------------------------------------
    //Freestyle to Level 1
    public void freestyleToLevelOne()
    {
        TimerScript.timerActive = false;
        Time.timeScale = 1;
        ItemInteraction.itemsFound = 0;
        TimerScript.gameWon = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

    //Freestyle to Level 2
    public void freestyleToLevelTwo()
    {
        TimerScript.timerActive = false;
        Time.timeScale = 1;
        ItemInteraction.itemsFound = 0;
        TimerScript.gameWon = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    //Freestyle to Level 3
    public void freestyleToLevelThree()
    {
        TimerScript.timerActive = false;
        Time.timeScale = 1;
        ItemInteraction.itemsFound = 0;
        TimerScript.gameWon = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    //Freestyle to Level 4
    public void freestyleToLevelFour()
    {
        TimerScript.timerActive = false;
        Time.timeScale = 1;
        ItemInteraction.itemsFound = 0;
        TimerScript.gameWon = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    //----------------------------------------------

    //Load back to main menu
    public void MainMenu()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (TimerScript.timerActive == true)
            {
                //Main menu
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                //Freestyle menu
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (TimerScript.timerActive == true)
            {
                //Main menu
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
            else
            {
                //Freestyle menu
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (TimerScript.timerActive == true)
            {
                //Main menu
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            }
            else
            {
                //Freestyle menu
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            if (TimerScript.timerActive == true)
            {
                //Main menu
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
            }
            else
            {
                //Freestyle menu
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        } 
        else if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        }
    }
}
  
