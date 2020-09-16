using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using UnityEngine;

public class moving_platform : MonoBehaviour
{
    public float movespeed;
    public GameObject platform;
    public Transform[] points;
    public int pointSelection;
    Transform currentPoint;
    public bool reversable;
    bool reversing;
    public float waitTime = 0;
    public bool waiting = false;
    float waitTimer;


    private void Start()
    {
        currentPoint = points[pointSelection];
        if (waiting == true)
            waitTimer = waitTime;
    }


    private void Update()
    {
        MovePlatform();

        if (platform.transform.position == currentPoint.position)
        {
            Debug.Log("Changing");
            ChangePoint();
        }
        PlatformWait();

    }

    private void ChangePoint()
    {
        if (reversable)
        {
            if (reversing)
            {
                pointSelection--;
                if (pointSelection < 0)
                {
                    pointSelection++;
                    reversing = false;
                }
            }else
            {
                pointSelection++;
                if (pointSelection == points.Length)
                {
                    pointSelection--;
                    reversing = true;
                }
            }
        }
        else
        {
            pointSelection++;
            if (pointSelection == points.Length)
            {
                pointSelection = 0;
            }
        }
                
        currentPoint = points[pointSelection];
        waitTimer = waitTime;
        waiting = true;
    }

    void MovePlatform()
    {
        if (waiting == true)
            return;
        platform.transform.position = Vector3.MoveTowards(platform.transform.position,
            currentPoint.position,
            Time.deltaTime * movespeed);
    }

    private void OnTriggerEnter2D(Collider2D co1)
    {
        co1.transform.parent = this.transform;
    }

    private void OnTriggerExit2D(Collider2D co1)
    {
        co1.transform.parent = null;
    }

    void PlatformWait()
    {
        if (waiting == true)
        {
            waitTimer -= Time.deltaTime;
            if (waitTimer <= 0)
            {
                waiting = false;
            }
        }
    }





}