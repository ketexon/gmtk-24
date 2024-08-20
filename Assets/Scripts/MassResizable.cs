using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassResizable : ResizableObject
{
    [SerializeField] float smallMass = 0.5f;
    [SerializeField] float defaultMass = 1f;
    [SerializeField] float largeMass = 2f;

    public override void Enlarge()
    {
        base.Enlarge();

        rigidbody.mass = largeMass;
    }

    public override void Shrink()
    {
        base.Shrink();

        rigidbody.mass = smallMass;
    }
}
