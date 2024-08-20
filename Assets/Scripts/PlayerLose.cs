using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLose : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.CompareTag("Obstacle")){
            Time.timeScale = 0;
            GameOverUI.Instance.Enable();
        }
    }
}
