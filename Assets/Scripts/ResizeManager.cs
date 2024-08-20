using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeManager : SingletonBehavior<ResizeManager>
{
    [SerializeField] LayerMask layerMask;

    [System.NonSerialized] public bool ResizeEnabled = true;

    Camera mainCamera;

    ResizableObject lastResizable = null;
    float lastHoverSoundTime = float.NegativeInfinity;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        ResizableObject resizableObject = null;

        var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out var hitInfo, float.PositiveInfinity, layerMask))
        {
            resizableObject = hitInfo.collider.GetComponent<ResizableObject>();
        }

        if (resizableObject)
        {
            if(ResizeEnabled){
                // Left click down
                if (Input.GetMouseButtonDown(0))
                {
                    resizableObject.Enlarge();
                }
                // Right click down
                else if (Input.GetMouseButtonDown(1))
                {
                    resizableObject.Shrink();
                }
            }
        }

        if(lastResizable != resizableObject){
            lastResizable = resizableObject;
            if(resizableObject && Time.time - lastHoverSoundTime > 0.5f){
                SFXManager.Instance.ScrollSize.Play();
                lastHoverSoundTime = Time.time;
            }
        }
    }
}
