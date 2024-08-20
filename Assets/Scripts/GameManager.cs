using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{

    static public bool gameRunning = false;
    public Button startButton;
    public CanvasGroup playMenuCanvasGroup;
    public CinemachineVirtualCamera startingVCam;

    // Start is called before the first frame update
    void Start()
    {
        gameRunning = false;
        startButton.onClick.AddListener(StartPlay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartPlay()
    {
        gameRunning = true;
        startingVCam.enabled = false;
        playMenuCanvasGroup.alpha = 0;
        playMenuCanvasGroup.blocksRaycasts = false;
    }
}
