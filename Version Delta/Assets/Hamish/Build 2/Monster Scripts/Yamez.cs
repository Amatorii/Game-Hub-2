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

    public override void Init()
    {
        eyecount = eyes.Length;
        //eyecount = 69;
        startingTime = Mathf.Pow(3, 2.8f - .1f * GameManager.Instance.nightNo) - 4;
        Debug.Log(startingTime);
        currentTime = startingTime;
        Eyetime = 3;
        eyesClosed = eyes.Length;
        timer = timeToOpen;
    }

    public override void Tick(float deltaTime)
    {
        currentTime -= Time.deltaTime;
        hereIcome();
        if (eyesClosed == 0)
            return;
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            eyesClosed -= 1;
            eyes[eyesClosed].material.SetTexture("_BaseMap", eyeOpen);
            timer = timeToOpen;
        }
    }

    public void hereIcome()
    {


        if (currentTime < 0)
        {
            Debug.Log(eyecount);
            eyecount -= 1;
            currentTime = Eyetime;
            eyes[eyecount].material.mainTexture = eyeOpen;

            if (eyecount < 0)
            {
                Debug.Log("U DED");
            }
        }
    }
}
