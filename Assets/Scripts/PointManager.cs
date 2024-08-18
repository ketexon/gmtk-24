using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{

    int points = 0;
    float timeIncrement = 0.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameRunning == true)
        {
            timeIncrement += Time.deltaTime;
            if (timeIncrement >= 1.0f)
            {
                points++;
                timeIncrement = 0;
                Debug.Log("points is: " + points);
            }

        }
        
    }
}
