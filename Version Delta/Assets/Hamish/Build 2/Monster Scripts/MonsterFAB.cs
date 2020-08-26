using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public abstract class MonsterFAB : MonoBehaviour
{
    public Animator MstAnime; //Animation for movement
    public int monsterActive; //Is it active
    protected int deltaTime;
    public int Mymurdertime; //Sets it's murder No. to send to the game manager
    protected bool canKill; //the script knows it can kill
    public bool awake = false;
    private int agression;
    public abstract void Init();

    public virtual void Tick(float deltaTime) //It's private version of time
    {
        if (awake == true)
        {

        }
    }
    protected virtual void Myagression(int agression)
    {
        this.agression = GameManager.Instance.nightNo;

        if(agression >= monsterActive)
        {
            awake = true;
            gameObject.SetActive(true);
        }
        else
        {
            awake = false;
            gameObject.SetActive(false);
        }
    }

    public virtual void seenquestion()
    {

    }
}
