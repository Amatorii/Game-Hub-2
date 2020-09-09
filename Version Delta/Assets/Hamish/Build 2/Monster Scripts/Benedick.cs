using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Benedick : MonsterFAB
{
    public float startTime = 5;
    public float currentTime;
    public PlayerCamera gamer;
    public Animator Anim;
    public bool checking;
    public bool checkForDeath;
    public override void Init()
    {
        Left();
    }

    public void Start()
    {
        Anim = GetComponent<Animator>();
    }

    public override void Tick(float deltaTime)
    {
        CzecTimer();
    }

    public void CzecTimer()
    {
        currentTime -= Time.deltaTime;
        if(currentTime <= 0 && checking == false)
        {
            checking = true;
            Anim.SetBool("checking", checking);
        }
        if(checkForDeath == true)
        {
            Killing();
        }
    }

    public void CheckForDeath()
    {
        checkForDeath = true;
    }

    public void Killing()
    {
        if (gamer.sleeping == false)
        {
            Debug.Log("U Dead");
        }
        else
        {
            Debug.Log("U no dead");
        }
    }

    public void Left()
    {
        checking = false;
        currentTime = Random.Range(minValue, maxValue);
        checkForDeath = false;
    }
}
