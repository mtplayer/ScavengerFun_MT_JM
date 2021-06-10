using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;

    public int itemsFound = 0;
    public int score = 0;
    public int level;

    private TextMeshProUGUI scoreText;
    private SceneChanger sceneChanger;
    private CanvasGroup canvasGroup;

    //public bool isAcceptableParam1 = true;
    //public bool isAcceptableParam2 = true;
    //public bool isAcceptableParam3 = true;
    //public bool isAcceptableParam4 = true;

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
  
    private void Update()
    {
        scoreText.text = itemsFound.ToString();

        if (itemsFound > 5 && level == 1)
        {
            sceneChanger.MainToLevelTwo();
            //sceneChanger.LevelChanger(6, "5 Level 2", 2);
            LevelLogoLoader.instance.SetLevelTwoLogoImage();
            Debug.Log("Collected 6");
            level++;
        }
        
        if (itemsFound > 15 && level == 2)
        {
            sceneChanger.MainToLevelThree();
            //sceneChanger.LevelChanger(16, "6 Level 3", 3);
            LevelLogoLoader.instance.SetLevelThreeLogoImage();
            Debug.Log("Collected 6 + 10 = 16");
            level++;
        }

        if (itemsFound > 29 && level == 3)
        {
            sceneChanger.MainToLevelFour();
            //sceneChanger.LevelChanger(30, "7 Level 4", 4);
            LevelLogoLoader.instance.SetLevelFourLogoImage();
            Debug.Log("Collected 6 + 10 + 14 = 30");
            level++;
        }

        if (itemsFound > 45 && level == 4 /*&& isAcceptableParam4 == true*/)
        {
            Debug.Log("Collected 6 + 10 + 14 + 16 = 46");
            //isAcceptableParam4 = false;

            //TODO
            print("YOU WIN!!!");//COOL SHIT
        }
    }
}