using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoSFX : MonoBehaviour
{
    [SerializeField] AudioSource source;

    float awakeTime;

    void Awake(){
        awakeTime = Time.time;
    }

    void OnCollisionEnter(Collision col){
        if(Time.time - awakeTime < 3.0f){
            return;
        }

        var strength = col.impulse.magnitude;
        source.PlayOneShot(source.clip, strength/5);
    }
}
