using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yamez : MonsterFAB
{
    public int eyecount;
    public float startingTime;
    public float currentTime;
    public int Eyetime;
    public MeshRenderer[] eyes;
    public int eyesClosed;
    public float timer;
    public Texture eyeOpen;
    public Texture eyeClosed;

    public override void Init()
    {
        base.Init();
        Mymurdertime = 3;
        TimerReset();
        ActionisComing = true;
    }

    public void TimerReset()
    {
        maxValue = Mathf.Pow(2, 5 - 0.2f * agression) + 6;
        minValue = Mathf.Pow(2, 5 - 0.2f * agression) + 2;
        startingTime = Random.Range(minValue, maxValue);
        Eyetime = Random.Range(7 - agression, 8 - agression);


        currentTime = startingTime;
        eyecount = eyes.Length;
        eyesClosed = eyes.Length;
        timer = Eyetime;
        Closeeyes();
        Debug.Log("Yamez is going to wait for " + startingTime);
        Debug.Log("Yamez is going open eyes in " + Eyetime);

    }

    public override void Tick(float deltaTime)
    {
        if (ActionisComing == false)
        {
            TimerReset();
        }
        if (ActionisComing == true)
        {
            hereIcome();
        }
        if (eyesClosed == 0)
        {
            return;
        }
        if (timer < 0)
        {
            eyesClosed -= 1;
            eyes[eyesClosed].material.SetTexture("_BaseMap", eyeOpen);
            timer = Random.Range(7 - agression, 8 - agression);
        }
        ActionisComing = true;
    }

    public void Closeeyes()
    {
        for (int i = 0; i < eyes.Length; i++)
        {
            eyes[i].material.SetTexture("_BaseMap", eyeClosed);
        }
    }

    public void hereIcome()
    {

        currentTime -= Time.deltaTime;
        timer -= Time.deltaTime;
        if (currentTime < 0)
        {
            Debug.Log(eyecount);
            eyecount -= 1;
            currentTime = Random.Range(7 - agression, 8 - agression); ;
            if (eyecount <= 0)
            {
                Debug.Log("U DED");
                Kill();
            }
            else
            {
                eyes[eyecount].material.mainTexture = eyeOpen;
            }
        }
    }
}
