using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] Transform postTutorialSpawn;
    [SerializeField] Transform player;

    static bool seenTutorial = false;

    void Awake(){
        if(seenTutorial){
            player.transform.position = postTutorialSpawn.transform.position;
        }

        seenTutorial = true;
    }
}
