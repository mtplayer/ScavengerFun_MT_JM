using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour, IPointerDownHandler
{
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ((IPointerDownHandler)button).OnPointerDown(eventData);
    }

    public void UseStartButton()
    {
        SceneChanger.instance.StartButtonToTutorial();
    }

    public void UseResumeButton()
    {
        //Screen.fullScreen = !Screen.fullScreen;
        SceneChanger.instance.LoadMainMenu();
        ScoreManager.instance.SetUIHeaderOff();
    }

    public void UseBackButton()
    {
        SceneChanger.instance.LoadMainMenu();
        ScoreManager.instance.SetUIHeaderOff();
    }

    //public void UseMain

    public void UseLevel1Button()
    {
        SceneChanger.instance.MainToLevelOne();
        ScoreManager.instance.SetUIHeaderOn();
    }

    public void UseLevel2Button()
    {
        SceneChanger.instance.MainToLevelTwo();
        ScoreManager.instance.SetUIHeaderOn();
        //button.interactable = false; 
    }

    public void UseLevel3Button()
    {
        SceneChanger.instance.MainToLevelThree();
        ScoreManager.instance.SetUIHeaderOn();
        //button.interactable = false; 
    }

    public void UseLevel4Button()
    {
        SceneChanger.instance.MainToLevelFour();
        ScoreManager.instance.SetUIHeaderOn();
        //button.interactable = false; 
    }
}