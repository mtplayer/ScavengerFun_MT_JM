using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Slider : MonoBehaviour
{
    [SerializeField]
    public Image progressBar;
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(LoadAsyncOperation(2));
    }

    IEnumerator LoadAsyncOperation(int sceneindex)
    {
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync(2);
        
        while (gameLevel.progress < 1)
        {
            progressBar.fillAmount = gameLevel.progress;
            yield return new WaitForEndOfFrame();
        }
    }
}
