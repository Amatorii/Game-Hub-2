using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Benedick : MonsterFAB
{
    public float startTime = 5;
    public float currentTime;
    public float comingTime;
    public float startComingTime = 5;
    public PlayerCamera gamer;
    public override void Init()
    {
        currentTime = startTime;
        comingTime = startComingTime;
    }

    public override void Tick(float deltaTime)
    {
        CzecTimer();
    }

    public void CzecTimer()
    {
        currentTime -= Time.deltaTime;
        if(currentTime <= 0)
        {
            comingTime -= Time.deltaTime;
            if(comingTime <= 0)
            {
                Killing();
            }
        }

    }

    public void Killing()
    {
        if (gamer.sleeping == false)
        {
            Debug.Log("U Dead");
        }
        else
        {
            currentTime = startTime;
            Debug.Log("U no dead");
            comingTime = startComingTime;
        }
    }
}
