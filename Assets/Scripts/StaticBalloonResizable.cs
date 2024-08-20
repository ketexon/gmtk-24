using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Balloon))]
public class StaticBalloonResizable : BalloonResizable
{
    Rigidbody rb;

    override protected void Awake(){
        base.Awake();
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    public override void Enlarge()
    {
        base.Enlarge();
        rb.isKinematic = false;
    }

    public override void Shrink()
    {
        base.Shrink();
        rb.isKinematic = false;
    }
}
