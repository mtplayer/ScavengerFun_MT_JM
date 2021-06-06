using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    #region Main Menu Stuff

    public void MainToLevelOne()
    {
        SetMainMenuValues();
        SceneManager.LoadScene("Level 1");
    }

    public void MainToLevelTwo()
    {
        SetMainMenuValues();
        SceneManager.LoadScene("Level 2");
    }

    public void MainToLevelThree()
    {
        SetMainMenuValues();
        SceneManager.LoadScene("Level 3");
    }

    public void MainToLevelFour()
    {
        SetMainMenuValues();
        SceneManager.LoadScene("Level 4");
    }

    public void MainToFreestyle()
    {
        SceneManager.LoadScene("Freestyle Menu");
    }

    #endregion

    #region Freestyle Stuff

    public void FreestyleToLevelOne()
    {
        SetFreestyleMenuValues();
        SceneManager.LoadScene("Level 1");
    }

    public void FreestyleToLevelTwo()
    {
        SetFreestyleMenuValues();
        SceneManager.LoadScene("Level 2");
    }

    public void FreestyleToLevelThree()
    {
        SetFreestyleMenuValues();
        SceneManager.LoadScene("Level 3");
    }

    public void FreestyleToLevelFour()
    {
        SetFreestyleMenuValues();
        SceneManager.LoadScene("Level 4");
    }

    #endregion

    public void Exit()
    {
        Application.Quit();

        //We need to add the URL quit button

    }

    public void LoadMainMenu()
    {
        //TODO Switch Statment

        if (SceneManager.GetActiveScene().buildIndex >= 1 || SceneManager.GetActiveScene().buildIndex <= 5)
        {
            SetMenu();
        
        //if (SceneManager.GetActiveScene().buildIndex == 1)
        //{
        //    SetMenu();
        //}
        //else if (SceneManager.GetActiveScene().buildIndex == 3)
        //{
        //    SetMenu();
        //}
        //else if (SceneManager.GetActiveScene().buildIndex == 4)
        //{
        //    SetMenu();
        //}
        //else if (SceneManager.GetActiveScene().buildIndex == 5)
        //{
        //    SetMenu();
        //}
        //else if (SceneManager.GetActiveScene().buildIndex == 6)
        //{
        //    SceneManager.LoadScene("Main Menu");
        }
        else
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    private static void SetMenu()
    {
        if (TimerScript.timerActive == true)
        {
            SceneManager.LoadScene("Main Menu");
        }
        else
        {
            SceneManager.LoadScene("Freestyle Menu");
        }
    }

    private void SetMainMenuValues()
    {
        TimerScript.timerActive = true;
        Time.timeScale = 1;
        ItemInteraction.itemsFound = 0;
        TimerScript.gameWon = false;
    }

    private void SetFreestyleMenuValues()
    {
        TimerScript.timerActive = false;
        Time.timeScale = 1;
        ItemInteraction.itemsFound = 0;
        TimerScript.gameWon = false;
    }
}