using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizableObject : MonoBehaviour
{
    [SerializeField] float resizeDuration = 0.25f;
    [SerializeField] float smallScale = 0.5f;
    [SerializeField] float defaultScale = 1;
    [SerializeField] float largeScale = 2;
    [SerializeField] AnimationCurve curve;

    new protected Rigidbody rigidbody;

    protected bool resized = false;
    protected float resizeStartTime;

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
    }

    virtual protected void Update()
    {
        if (!resized) return;
        var t = (Time.time - resizeStartTime) / resizeDuration;
        if(t > 1)
        {
            transform.localScale = Vector3.one * targetScale;
            Destroy(this);
        }
        else
        {
            var currentScale = Mathf.Lerp(defaultScale, targetScale, curve.Evaluate(t));
            transform.localScale = Vector3.one * currentScale;
        }
    }

    virtual public void Enlarge()
    {
        if (resized) return;
        targetScale = largeScale;
        resized = true;
        resizeStartTime = Time.time;
    }

    virtual public void Shrink()
    {
        if (resized) return;
        targetScale = smallScale;
        resized = true;
        resizeStartTime = Time.time;
    }
}
