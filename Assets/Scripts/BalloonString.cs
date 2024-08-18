using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class BalloonString : MonoBehaviour
{
    [SerializeField] Transform start;
    [SerializeField] Transform end;

    LineRenderer lineRenderer;

    Vector3[] points = new Vector3[2];

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        points[0] = start.position;
        points[1] = end.position;
        lineRenderer.SetPositions(points);
    }
}
