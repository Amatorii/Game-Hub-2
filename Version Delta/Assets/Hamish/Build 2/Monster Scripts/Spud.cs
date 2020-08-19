using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spud : MonsterFAB
{
    public Transform Window;
    public Transform windowClose;
    public Transform windowOpen;
    public float windowPos = 0;
    public float Movespeed = 5;
    public Transform resetPoint;
    public float startingtime;
    float currenttime;
    public override void Init()
    {
        windowPos = 0;
        Movespeed = 1;
        //startingtime = 1;
        startingtime = Mathf.Pow(1.9f, 5.6f - 0.14f * GameManager.Instance.nightNo) + 5;
    }

    public override void Tick(float deltaTime)
    {
        IMCOMING();
        ActionisComing = true;
    }

    public void IMCOMING()
    {
        Window.position = Vector3.Lerp(windowClose.position, windowOpen.position, windowPos);
        if(ActionisComing == false)
        {
            transform.position = resetPoint.position;
            currenttime = startingtime;
            Debug.Log("Spud Says No");
        }
        if (ActionisComing == true)
        {
            Debug.Log("Siggidy Swoodi");
            currenttime -= Time.deltaTime;
            if (currenttime <= 0)
            {
                windowPos += 0.3f * Time.deltaTime;
                if (1 < windowPos)
                {
                    transform.Translate(Vector3.forward * Time.deltaTime * Movespeed);

                }
            }
        }
    }
}
