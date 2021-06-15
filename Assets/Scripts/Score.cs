using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;

    public int itemsFound = 0;
    public int score = 0;
    public int level = 0;

    private TextMeshProUGUI scoreText;
    private SceneChanger sceneChanger;
    private CanvasGroup canvasGroup;

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

        if (itemsFound > 5 && level == 1)
        {
            sceneChanger.MainToLevelTwo();
        }
        
        if (itemsFound > 9 && level == 2)
        {
            sceneChanger.MainToLevelThree();
        }

        if (itemsFound > 13 && level == 3)
        {
            sceneChanger.MainToLevelFour();
        }

        if (itemsFound > 15 && level == 4)
        {
            Debug.Log("Collected 6 + 10 + 14 + 16 = 46");
            //TODO
            print("YOU WIN!!!");//COOL SHIT
        }
    }


}