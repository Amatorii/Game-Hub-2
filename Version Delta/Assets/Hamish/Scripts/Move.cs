﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    bool moving = true;
    public float startingtime = 2;
    float currenttime;
    public float Movespeed = 5;

    // Start is called before the first frame update
    public void StopMove()
    {
        Debug.Log("stop");
        moving = false;
    }

    private void Moving()
    {
        if (moving == false)
        {
            currenttime = startingtime;
            Debug.Log("Not Moving");
        }
        if (moving == true)
        {
            currenttime -= 1 * Time.deltaTime;
            //currenttime.ToString("0");
            if (currenttime <= 0)
            {
                //transform.Translate(Vector3.forward * Time.deltaTime);
                transform.Translate(Vector3.forward * Time.deltaTime*Movespeed);
            }
        }

    }

    void Start()
    {
        currenttime = startingtime;
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        moving = true;
    }
}