using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizableObject : MonoBehaviour
{
    [SerializeField] protected float resizeDuration = 0.25f;
    [SerializeField] float smallScale = 0.5f;
    [SerializeField] float defaultScale = 1;
    [SerializeField] float largeScale = 2;
    [SerializeField] AnimationCurve curve;

    public bool CanResize { get; private set; } = true;

    virtual protected bool DestroyAfter => true;

    new protected Rigidbody rigidbody;

    protected bool resizing = false;
    protected float resizeStartTime;
    protected float resizeStartScale;

    float targetScale;

    virtual protected void Reset()
    {
        curve = new AnimationCurve(
            new Keyframe(0, 0, 0, 1.5f),
            new Keyframe(1, 1, 0, 0)
        );
    }

    virtual protected void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        targetScale = defaultScale;
    }

    virtual protected void Update()
    {
        if (!resizing) return;
        var t = (Time.time - resizeStartTime) / resizeDuration;
        if(t > 1)
        {
            transform.localScale = Vector3.one * targetScale;
            if(DestroyAfter) {
                Destroy(this);
            }
            resizing = false;
        }
        else
        {
            var currentScale = Mathf.Lerp(resizeStartScale, targetScale, curve.Evaluate(t));
            transform.localScale = Vector3.one * currentScale;
        }
    }

    virtual protected void ResetResizable(){
        ResizeInternal(defaultScale);
        CanResize = true;
    }

    virtual public void Enlarge()
    {
        if (!CanResize) return;
        ResizeInternal(largeScale);
        CanResize = false;
    }

    virtual public void Shrink()
    {
        if (!CanResize) return;
        ResizeInternal(smallScale);
        CanResize = false;
    }

    void ResizeInternal(float newTargetScale){
        resizeStartScale = targetScale;
        targetScale = newTargetScale;
        resizing = true;
        resizeStartTime = Time.time;
    }
}
