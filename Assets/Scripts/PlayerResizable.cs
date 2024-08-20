using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResizable : ResizableObject
{
    [SerializeField] float smallDuration = 5.0f;

    protected override bool DestroyAfter => false;

    public override void Shrink()
    {
        base.Shrink();

        ResizeManager.Instance.ResizeEnabled = false;
        this.WaitThenDo(smallDuration, () => {
            ResizeManager.Instance.ResizeEnabled = true;
            ResetResizable();
        });
    }

    public override void Enlarge()
    {
        // Do nothing on enlarge
    }
}
