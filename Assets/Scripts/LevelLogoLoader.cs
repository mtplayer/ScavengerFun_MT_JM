using UnityEngine;

public class LevelLogoLoader : MonoBehaviour
{
    public static LevelLogoLoader instance;

    public GameObject levelOneLogoImage;
    public GameObject levelTwoLogoImage;
    public GameObject levelThreeLogoImage;
    public GameObject levelFourLogoImage;

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

        SetMainMenuLogoImage();
    }

    public void SetMainMenuLogoImage()
    {
        levelOneLogoImage.SetActive(false);
        levelTwoLogoImage.SetActive(false);
        levelThreeLogoImage.SetActive(false);
        levelFourLogoImage.SetActive(false);
    }

    public void SetLevelOneLogoImage()
    {
        levelOneLogoImage.SetActive(true);
        levelTwoLogoImage.SetActive(false);
        levelThreeLogoImage.SetActive(false);
        levelFourLogoImage.SetActive(false);
    }

    public void SetLevelTwoLogoImage()
    {
        levelOneLogoImage.SetActive(false);
        levelTwoLogoImage.SetActive(true);
        levelThreeLogoImage.SetActive(false);
        levelFourLogoImage.SetActive(false);
    }

    public void SetLevelThreeLogoImage()
    {
        levelOneLogoImage.SetActive(false);
        levelTwoLogoImage.SetActive(false);
        levelThreeLogoImage.SetActive(true);
        levelFourLogoImage.SetActive(false);
    }

    public void SetLevelFourLogoImage()
    {
        levelOneLogoImage.SetActive(false);
        levelTwoLogoImage.SetActive(false);
        levelThreeLogoImage.SetActive(false);
        levelFourLogoImage.SetActive(true);
    }
}