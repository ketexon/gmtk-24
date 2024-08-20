using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResizable : ResizableObject
{
    [SerializeField] float smallDuration = 5.0f;
    [SerializeField] Renderer normalMesh;
    [SerializeField] Renderer smallMesh;

    protected override bool DestroyAfter => false;

    public override void Shrink()
    {
        base.Shrink();

        this.WaitThenDo(resizeDuration, () => {
            normalMesh.enabled = false;
            smallMesh.enabled = true;
        });

        ResizeManager.Instance.ResizeEnabled = false;
        this.WaitThenDo(smallDuration, () => {
            normalMesh.enabled = true;
            smallMesh.enabled = false;

            ResizeManager.Instance.ResizeEnabled = true;
            ResetResizable();
        });
    }

    public override void Enlarge()
    {
        // Do nothing on enlarge
    }
}
