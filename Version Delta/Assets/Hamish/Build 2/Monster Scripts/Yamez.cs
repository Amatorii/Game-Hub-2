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
    public Texture eyeOpen;
    public Texture eyeClosed;

    public override void Init()
    {
        eyecount = eyes.Length;
        //eyecount = 69;
        startingTime = Mathf.Pow(3, 2.8f - .1f * GameManager.Instance.nightNo) - 4;
        Debug.Log(startingTime);
        currentTime = startingTime;
        Eyetime = 3;
    }

    public override void Tick(float deltaTime)
    {
        currentTime -= Time.deltaTime;
        hereIcome();
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

    void CloseEyes()
    {
        for (int i = 0; i < eyes.Length; i++)
        {
            eyes[i].material.mainTexture = eyeClosed;
        }
        eyecount = eyes.Length;
    }

}
