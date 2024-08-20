using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeManager : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;

    Camera mainCamera;

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
}
