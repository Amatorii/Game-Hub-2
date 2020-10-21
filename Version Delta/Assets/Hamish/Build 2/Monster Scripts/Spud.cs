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
    public float deathTimer;
    public override void Init()
    {
        base.Init();
        Mymurdertime = 1;
        windowPos = 0;
        Movespeed = 1;
        maxValue = Mathf.Pow(2.5f, 5.3f - 0.14f * agression) - 75;
        minValue = Mathf.Pow(2.3f, 5.6f - 0.14f * agression) - 70;
        currenttime = weightedRandom(minValue, maxValue);
        deathTimer = 6;
    }

    public override void Tick(float deltaTime)
    {
        IMCOMING();
        ActionisComing = true;
        if(deathTimer < 0)
        {
            Kill();
        }
    }

    float weightedRandom(float min, float max)
    {
        float ans;
        float roll1 = Random.Range(min, max);
        float roll2 = Random.Range(min, max);
        float roll3 = Random.Range(min, max);
        float roll4 = Random.Range(min, max);

        ans = Mathf.Max(roll1, roll2, roll3, roll4);

        Debug.Log(ans);
        return ans;
    }

    public void IMCOMING()
    {
        Window.position = Vector3.Lerp(windowClose.position, windowOpen.position, windowPos);
        if(ActionisComing == false)
        {
            transform.position = resetPoint.position;
            currenttime = weightedRandom(minValue, maxValue);
            deathTimer = 6;
        }
        if (ActionisComing == true)
        {
            currenttime -= Time.deltaTime;
            if (currenttime <= 0)
            {
                windowPos += 0.3f * Time.deltaTime;
                if (1 < windowPos)
                {
                    transform.Translate(Vector3.forward * Time.deltaTime * Movespeed);
                    deathTimer -= Time.deltaTime;
                }
            }
        }
    }
}
