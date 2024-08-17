using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.position += speed * Time.deltaTime * transform.forward;
    }
}
