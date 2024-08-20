using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : SingletonBehavior<SFXManager>
{
    public AudioSource BlockHit;
    public AudioSource Hover;
    public AudioSource PickUp;
    public AudioSource ScrollSize;
    public AudioSource BalloonGrow;
    public AudioSource BalloonShrink;
}
