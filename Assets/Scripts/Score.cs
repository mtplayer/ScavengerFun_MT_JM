using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;


    public int itemsFound = 0;


    public int score = 0;


    //public int level1Items = 5;
    //public int level2Items = 9;
    //public int level3Items = 13;
    //public int level4Items = 15;

    //public bool isGreaterThan5;
    //public bool isGreaterThan9;
    //public bool isGreaterThan15; 
    //private bool isGreaterThan20;

    private TextMeshProUGUI scoreText;
    private SceneChanger sceneChanger;

    private bool isAcceptableParam = true;
    private bool isAcceptableParam2 = true;
    private bool isAcceptableParam3 = true;
    private bool isAcceptableParam4 = true;

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
    }

    //private void Update()
    //{
    //    scoreText.text = itemsFound.ToString();

    //    if (itemsFound > level1Items && !isGreaterThan5)
    //    {
    //        itemsFound = 0;
    //        isGreaterThan5 = true;
    //        sceneChanger.MainToLevelTwo();
    //        Debug.Log("Reached 5");
    //    }

    //    if (itemsFound >7)
    //    {
    //        Debug.Log("Reached 10");
    //        itemsFound = 0;
    //        isGreaterThan9 = true;
    //        sceneChanger.MainToLevelThree();
    //    }
    //    if (itemsFound > level3Items && isGreaterThan9)
    //    {
    //        itemsFound = 0;
    //        isGreaterThan15 = true;
    //        sceneChanger.MainToLevelFour();
    //    }
    //}
    private void Update()
    {
        scoreText.text = itemsFound.ToString();

        if (itemsFound > 5 && isAcceptableParam == true)
        {
            //itemsFound = 6;
            //isGreaterThan5 = true;
            sceneChanger.MainToLevelTwo();
            Debug.Log("Reached 6");
            isAcceptableParam = false;
        }
        
        if (itemsFound > 15 && isAcceptableParam2 == true)
        {
            //itemsFound = 
            //isGreaterThan9 = true;
            sceneChanger.MainToLevelThree();
            Debug.Log("Reached 6 + 10 = 16");
            isAcceptableParam2 = false;
        }

        if (itemsFound > 29 && isAcceptableParam3 == true)
        {
            //itemsFound = 0;
            //isGreaterThan15 = true;
            sceneChanger.MainToLevelFour();
            Debug.Log("Reached 6 + 10 + 14 = 30");
            isAcceptableParam3 = false;
        }

        if (itemsFound > 45 && isAcceptableParam4 == true)
        {
            //itemsFound = 0;
            //isGreaterThan15 = true;
            //sceneChanger.MainToLevelFour();
            Debug.Log("Reached 6 + 10 + 14 + 16 = 46");
            isAcceptableParam4 = false;
            print("YOU WIN!!!");
        }
    }
}