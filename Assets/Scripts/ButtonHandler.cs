using TMPro;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject image;
    public GameObject button;

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

        // reference score text
        //scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        if (found)
        {
            itemsFound = itemsFound + 1;
            scoreText.text = itemsFound.ToString();
        }        
    }
}
