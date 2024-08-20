using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Animator animator;

    void Start(){
        animator.SetBool("running", true);
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * transform.forward;
    }
}
