using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static SceneChanger instance;

    private void Start()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #region Main Menu Stuff
    public void StartButtonToTutorial()
    {
        SceneManager.LoadScene("2 Tutorial Screen");
    }

    //public void LevelChanger(string _sceneName, int _itemsFound, int _level)
    //{
    //    SceneManager.LoadScene(_sceneName);
    //    Score.instance.itemsFound = _itemsFound;
    //    Score.instance.level = _level;
    //}

    public void LoadMainMenu()
    {
        LevelLogoLoader.instance.SetMainMenuLogoImage();
        SceneManager.LoadScene("3 Main Menu");
        Score.instance.itemsFound = 0;
        Score.instance.score = 0;/////////////////
        Score.instance.level = 0;
        TimerManager.instance.CurrentTime = 0;
        TimerManager.instance.timerActive = false;
    }

    public void MainToLevelOne()
    {
        LevelLogoLoader.instance.SetLevelOneLogoImage();
        SceneManager.LoadScene("4 Level 1");        
        Score.instance.itemsFound = 0;
        Score.instance.level = 1;
        TimerManager.instance.CurrentTime = 30;
        TimerManager.instance.timerActive = true;
    }

    public void MainToLevelTwo()
    {
        LevelLogoLoader.instance.SetLevelTwoLogoImage();
        SceneManager.LoadScene("5 Level 2");
        Score.instance.itemsFound = 0;
        Score.instance.level = 2;
        TimerManager.instance.CurrentTime = 40;
    }

    public void MainToLevelThree()
    {
        LevelLogoLoader.instance.SetLevelThreeLogoImage();
        SceneManager.LoadScene("6 Level 3");
        Score.instance.itemsFound = 0;
        Score.instance.level = 3;
        TimerManager.instance.CurrentTime = 50;
    }

    public void MainToLevelFour()
    {
        LevelLogoLoader.instance.SetLevelFourLogoImage();
        SceneManager.LoadScene("7 Level 4");
        Score.instance.itemsFound = 0;
        Score.instance.level = 4;
        TimerManager.instance.CurrentTime = 60;
    }
    #endregion

    public void Exit()
    {
        Application.Quit();
        //TODO
        //We need to add the URL quit button
    }  
}