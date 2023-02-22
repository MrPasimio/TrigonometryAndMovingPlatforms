using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillatingPlatform : MonoBehaviour
{
    private Vector2 startingPosition;
    private float xPos;
    private float yPos;

    //Horizontal Variables
    public bool isMovingHorizontally;
    public bool isXUsingCosine;
    public float xAmp;
    public float xPer = 1f;

    //Vertical Variables
    public bool isMovingVertically;
    public bool isYUsingCosine;
    public float yAmp;
    public float yPer = 1f;


    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if(isMovingHorizontally)
        {
            float b = 6.28f / xPer;
            if (isXUsingCosine)
            {
                xPos = startingPosition.x + xAmp * Mathf.Cos(Time.time * b);
            }
            else
            {
                xPos = startingPosition.x + xAmp * Mathf.Sin(Time.time * b);
            }
        }
        else
        {
            xPos = transform.position.x;
        }

        if (isMovingVertically)
        {
            float b = 6.28f/yPer;
            if (isYUsingCosine)
            {
                yPos = startingPosition.y + yAmp * Mathf.Cos(Time.time * b);
            }
            else
            { 
                yPos = startingPosition.y + yAmp * Mathf.Sin(Time.time * b);
            }
        }
        else
        {
            yPos = transform.position.y;
        }

        transform.position = new Vector2(xPos, yPos);


    }
}
