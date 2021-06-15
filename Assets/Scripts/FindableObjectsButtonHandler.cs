using UnityEngine;

public class FindableObjectsButtonHandler : MonoBehaviour
{
    public GameObject image;
    public GameObject button;

    private ScoreManager score;

    private void Start()
    {
        score = FindObjectOfType<ScoreManager>();
    }

    public void SetItemInventoryList()//USes the unity default buttn event system
    {
        score.itemsFound++;
        image.SetActive(false);
        button.SetActive(false);
    }
}