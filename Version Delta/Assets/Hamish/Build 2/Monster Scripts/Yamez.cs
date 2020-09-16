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
    public float timeToOpen = 1;
    public Texture eyeOpen;
    public Texture eyeClosed;

    public override void Init()
    {
        eyecount = eyes.Length;
        startingTime = Mathf.Pow(3, 2.8f - .1f * GameManager.Instance.nightNo) - 4;
        currentTime = startingTime;
        Eyetime = 3;
        eyesClosed = eyes.Length;
        timer = timeToOpen;

        ActionisComing = true;
    }

    public override void Tick(float deltaTime)
    {
        if (ActionisComing == false)
        {
            eyecount = eyes.Length;
            currentTime = startingTime;
            Eyetime = 3;
            eyesClosed = eyes.Length;
            timer = timeToOpen;
            Closeeyes();
        }
        if(ActionisComing == true)
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
            timer = timeToOpen;
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
            currentTime = Eyetime;
            if (eyecount <= 0)
            {
                Debug.Log("U DED");
                GameManager.Instance.TimetoDie(2);
            }
            else
            {
                eyes[eyecount].material.mainTexture = eyeOpen;
            }
        }
    }
}
