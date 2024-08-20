using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Animator animator;
    [SerializeField] CharacterController characterController;
    bool running = false;

    void Start(){
        
    }

    void Update()
    {
        if (GameManager.gameRunning)
        {
            if (!running)
            {
                animator.SetBool("running", true);
                running = true;
            }
            characterController.SimpleMove(speed * transform.forward);
        }
    }

    void OnCollisionEnter(Collision collision){

    }
}
