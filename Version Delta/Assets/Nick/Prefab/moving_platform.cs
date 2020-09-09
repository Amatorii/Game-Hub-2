using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class moving_platform : MonoBehaviour
{
    public float movespeed;
    public GameObject platform;
    public Transform[] points;
    public int pointSelection;
    Transform currentPoint;


    private void Start()
    {
        currentPoint = points[pointSelection];
    }


    private void Update()
    {
        MovePlatform();

        if (platform.transform.position == currentPoint.position)
        {
            ChangePoint();
        }

    }

    private void ChangePoint()
    {
        pointSelection++;
        if (pointSelection == points.Length)
        {
            pointSelection = 0;
        }
        currentPoint = points[pointSelection];
    }

    void MovePlatform()
    {

    }
}