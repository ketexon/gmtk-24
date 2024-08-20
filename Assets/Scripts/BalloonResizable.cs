using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Balloon))]
public class BalloonResizable : ResizableObject
{
    [SerializeField] float smallLift = 0.5f;
    [SerializeField] float defaultLift = 1;
    [SerializeField] float largeLift = 2;

    Balloon balloon;

    override protected void Awake()
    {
        base.Awake();
        balloon = GetComponent<Balloon>();

        balloon.Lift = defaultLift;
    }

    public override void Enlarge()
    {
        base.Enlarge();
        balloon.Lift = largeLift;
        SFXManager.Instance.BalloonGrow.Play();
    }

    public override void Shrink()
    {
        base.Shrink();
        balloon.Lift = smallLift;
        SFXManager.Instance.BalloonShrink.Play();
    }
}
