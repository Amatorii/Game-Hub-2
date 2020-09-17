using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public abstract class MonsterFAB : MonoBehaviour
{
    protected int deltaTime;
    public int Mymurdertime; //Sets it's murder No. to send to the game manager
    public bool awake = false;
    public int agression;
    public bool ActionisComing;
    public float minValue;
    public float maxValue;

    public abstract void Init();

    public virtual void Tick(float deltaTime) //It's private version of time
    {
        ActionisComing = true;
        agression = GameManager.Instance.nightNo;
    }

    public void Kill()
    {
        Cursor.lockState = CursorLockMode.None;
        GameManager.Instance.TimetoDie(Mymurdertime);
    }

    public virtual void seenquestion()
    {
        ActionisComing = false; 
    }
}
