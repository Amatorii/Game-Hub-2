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
    public GameObject model;

    public override void Init()
    {
        Debug.Log("Yamez's murder time " + Mymurdertime + " : " + GameManager.Instance.nightNo);
        if (Mymurdertime > GameManager.Instance.nightNo)
        {
            model.SetActive(false);
            return;
        }
        model.SetActive(true);
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
    }

    public override void Tick(float deltaTime)
    {
        if (Mymurdertime > GameManager.Instance.nightNo)
        { 
            return;
        }

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
            Debug.Log("Yamez has " + (6 - eyesClosed) + " eyes open");
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
            eyecount -= 1;
            currentTime = Random.Range(7 - agression, 8 - agression); ;
            if (eyecount <= 0)
            {
                Debug.Log("Yamez Killed you");
                Kill();
            }
            else
            {
                eyes[eyecount].material.mainTexture = eyeOpen;
            }
        }
    }
}
