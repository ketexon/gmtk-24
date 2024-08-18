using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Button startButton;
    static public bool gameRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(TaskOnStart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnStart()
    {
        gameRunning = true;
    }
}
