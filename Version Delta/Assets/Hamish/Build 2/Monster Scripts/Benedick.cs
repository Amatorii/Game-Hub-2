using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Benedick : MonsterFAB
{
    public float startTime = 5;
    public float currentTime;
    public float comingTime;
    public float startComingTime = 5;

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
            transform.Rotate(Vector3.up * Time.deltaTime * 36);
            if(comingTime <= 0)
            {
                NaughtyorNice();
            }
        }

    }
    public void NaughtyorNice()
    {
        if(GameManager.Instance.sleep == true)
        {
            Debug.Log("You're Safe");
        }
        else
        {
            Debug.Log("omae wa mou shindeiru");
        }
        transform.Rotate(Vector3.up * 180);
        currentTime = startTime;
        comingTime = startComingTime;
    }
}
