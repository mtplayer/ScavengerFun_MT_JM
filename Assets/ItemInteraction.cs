using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInteraction : MonoBehaviour
{

    // Score tracking properties
    public static int itemsFound = 0;
    private Text scoreText;

    // Item dynamic properties
    public Rigidbody2D rb;
    public bool found = false;
    private bool lerping = false;
    
    private float timeStartedLerp;
    private float lerpTime;

    private Vector2 startPosition;
    private Vector2 endPosition;

    private Vector2 startScale;
    private Vector2 endScale;
    
    // Called at set up
    void Start ()
    {
        // reference score text
        scoreText = GameObject.Find("Score").GetComponent<Text>();

        // set start position to object position
        startPosition.x = rb.position.x;
        startPosition.y = rb.position.y;

        // set start size to scale of object
        startScale.x = transform.localScale.x;
        startScale.y = transform.localScale.y;

        // set lerp time
        lerpTime = 0.3f;

        // set end position
        endPosition.x = scoreText.transform.position.x;
        endPosition.y = scoreText.transform.position.y;

        // set end scale
        endScale.x = 0;
        endScale.y = 0;

    } 

    // Update is called once per frame
    void FixedUpdate()
    {
        if (found && !lerping && Time.timeScale == 1)
        {
            startLerping();
            lerping = true;
            itemsFound = itemsFound + 1;
            scoreText.text = "Found: " + itemsFound.ToString();
        }
        if (lerping)
        {
            rb.position = Lerp(startPosition, endPosition, timeStartedLerp, lerpTime);
            transform.localScale = Lerp(startScale, endScale, timeStartedLerp, lerpTime);
        }
    }


    // On mouse click on object
    void OnMouseDown()
    {         
	    // this object was clicked - do something     
        found = true; 
    }   



    // Lerping functions
    private void startLerping()
    {
        timeStartedLerp = Time.time;
    }

    public Vector2 Lerp(Vector2 start, Vector2 end, float timeStartedLerp, float lerpTime)
    {
        float timeSinceStarted = Time.time - timeStartedLerp;
        float percentageComplete = timeSinceStarted / lerpTime;

        var result = Vector2.Lerp(start, end, percentageComplete);
        return result;
    }

}
