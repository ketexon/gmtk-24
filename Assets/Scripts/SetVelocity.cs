using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SetVelocity : MonoBehaviour
{
    [SerializeField] Vector3 velocity;

    void Awake(){
        GetComponent<Rigidbody>().velocity = velocity;
    }
}
