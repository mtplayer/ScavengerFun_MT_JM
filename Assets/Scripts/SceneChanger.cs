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

    public void LoadMainMenu()//////
    {
        LevelLogoLoader.instance.SetMainMenuLogoImage();///////

        SceneManager.LoadScene("3 Main Menu");
        Score.instance.itemsFound = 0;
        Score.instance.score = 0;

        Score.instance.SetUIHeaderOff();
    }

    public void LevelChanger(int _itemsFound, string _sceneName /*LevelLogoLoader _setLevelLogo*/, int _level)
    {
        Score.instance.itemsFound = _itemsFound;
        SceneManager.LoadScene(_sceneName);
        //LevelLogoLoader.instance.SetLevelOneLogoImage();
        Score.instance.level = _level;
    }

    public void MainToLevelOne()
    {
        Score.instance.itemsFound = 0;
        SceneManager.LoadScene("4 Level 1");
        LevelLogoLoader.instance.SetLevelOneLogoImage();
        Score.instance.level = 1;   
    }

    public void MainToLevelTwo(/*int itemsFound*/)
    {
        //Score.instance.itemsFound = itemsFound;

        Score.instance.itemsFound = 6;
        SceneManager.LoadScene("5 Level 2");
        LevelLogoLoader.instance.SetLevelTwoLogoImage();
        Score.instance.level = 2;
    }

    public void MainToLevelThree()
    {
        Score.instance.itemsFound = 16;
        SceneManager.LoadScene("6 Level 3");
        LevelLogoLoader.instance.SetLevelThreeLogoImage();
        Score.instance.level = 3;
    }

    public void MainToLevelFour()
    {
        Score.instance.itemsFound = 30;
        SceneManager.LoadScene("7 Level 4");
        LevelLogoLoader.instance.SetLevelFourLogoImage();
        Score.instance.level = 4;
    }

    #endregion

    public void Exit()
    {
        Application.Quit();
        //TODO
        //We need to add the URL quit button
    }  
}