using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Animator animator;
    [SerializeField] CharacterController characterController;

    void Start(){
        animator.SetBool("running", true);
    }

    void Update()
    {
        characterController.SimpleMove(speed * transform.forward);
    }

    void OnCollisionEnter(Collision collision){

    }
}
