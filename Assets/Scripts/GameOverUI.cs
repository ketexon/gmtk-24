using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    CanvasGroup cg;

    void Awake(){
        cg = GetComponent<CanvasGroup>();
    }

    public void Enable(){
       cg.alpha = 0;
       cg.blocksRaycasts = false;
    }

    public void Disable(){
        cg.alpha = 1;
        cg.blocksRaycasts = true;
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
