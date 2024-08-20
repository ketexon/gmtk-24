using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyResizable : ResizableObject
{
    [SerializeField] ResizableObject resizable;

    override protected void Reset(){
        base.Reset();
        if(transform.parent){
            resizable = transform.parent.GetComponentInParent<ResizableObject>();
        }
    }

    public override void Enlarge()
    {
        resizable.Enlarge();
    }

    public override void Shrink()
    {
        resizable.Shrink();
    }
}
