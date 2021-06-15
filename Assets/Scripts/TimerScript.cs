//using UnityEngine;
//using TMPro;

//public class TimerScript : MonoBehaviour
//{
//    public static bool timerActive = true;//
//    public bool canMoveTime = true;

//    public int maxTime;
//    public int currentTime;

//    private TextMeshProUGUI timerText;

//    private void Start()
//    {
//        timerText = GetComponent<TextMeshProUGUI>();

//        timerText.text =  maxTime.ToString();
//        currentTime = maxTime;
//    }

//    private void FixedUpdate()//////
//    {
//        if (currentTime > 0 && !canMoveTime)
//        {
//            Debug.Log("Can this ever run!!!!!!");

//            if (timerActive)
//            {
//                currentTime = (int)Mathf.Ceil(maxTime - Time.timeSinceLevelLoad);//////////////////
//                timerText.text = currentTime.ToString();
//            }
//            else
//            {
//                timerText.text = "";
//            }
//        }

//       if (currentTime <= 0)
//        {
//            SceneChanger.instance.LoadMainMenu();
//            currentTime = maxTime;
//        }
//    }
//}