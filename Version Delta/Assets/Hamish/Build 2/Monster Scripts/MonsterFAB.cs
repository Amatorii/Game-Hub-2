﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public abstract class MonsterFAB : MonoBehaviour
{
    public Animator MstKill; //Animation for movement
    public int monsterActive; //Is it active
    protected int deltaTime;
    public int Mymurdertime; //Sets it's murder No. to send to the game manager
    public bool awake = false;
    private int agression = GameManager.Instance.nightNo;
    public bool ActionisComing;
    public float minValue;
    public float maxValue;

    public abstract void Init();

    public virtual void Tick(float deltaTime) //It's private version of time
    {
        ActionisComing = true;
    }

    public virtual void seenquestion()
    {
        ActionisComing = false; 
    }
}
