using UnityEngine;

public class FindableObjectsButtonHandler : MonoBehaviour
{
    public GameObject image;
    public GameObject button;

    private Score score;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }

    public void SetItemInventoryList()//USes the unity default buttn event system
    {
        score.itemsFound++;
        image.SetActive(false);
        button.SetActive(false);
    }
}