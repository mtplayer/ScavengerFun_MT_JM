using TMPro;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject image;
    public GameObject button;

    public SceneChanger sceneChanger;

    // Score tracking properties
    public static int itemsFound = 0;
    public TextMeshProUGUI scoreText;
    public bool found = false;

    public void SetItemInventoryList()
    {
        image.SetActive(false);
        button.SetActive(false);

        itemsFound = itemsFound + 1;
        scoreText.text = itemsFound.ToString();

        Debug.Log(itemsFound + " + 1");

        // reference score text
        //scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (found)
        {
            itemsFound = itemsFound + 1;
            
            scoreText.text = itemsFound.ToString();
        }

        if (itemsFound == 6)
        {
            Debug.Log("ScreenChange++");
            sceneChanger.MainToLevelTwo();
        }
    }

    public int GetItemsFound(int items)
    {
        int myItemsFound = items;

        return myItemsFound;
    }
}
