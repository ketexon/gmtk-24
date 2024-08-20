using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : SingletonBehavior<GameOverUI>
{
    CanvasGroup cg;

    override protected void Awake(){
        base.Awake();
        cg = GetComponent<CanvasGroup>();
        Disable();
    }

    public void Enable(){
        cg.alpha = 1;
        cg.blocksRaycasts = true;
    }

    public void Disable(){
        cg.alpha = 0;
        cg.blocksRaycasts = false;
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
