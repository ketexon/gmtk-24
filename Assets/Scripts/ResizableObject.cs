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

    bool resized = false;
    float resizeStartTime;
    float targetScale;

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
