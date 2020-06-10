using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public abstract class MonsterFAB : MonoBehaviour
{
    public Animator MstAnime; //Animation for movement
    private float Timer = 10; //Base timer
    float Ctimer;
    public int monsterActive; //Is it active
    protected int deltaTime;
    public int Mymurdertime; //Sets it's murder No. to send to the game manager
    private bool canKill; //the script knows it can kill
    public int aggression;
    public abstract void Init();

    public virtual void Tick(float deltaTime) //It's private version of time
    {
        Debug.Log("Generic Monster");
        //Functionallity Goes here
    }


        public virtual void Kill()
    {
        if(canKill == true)
        {
            GameManage.Instance.TimetoDie(Mymurdertime);
        }
    }

    public virtual void Activity()
    {
        if(Mymurdertime == GameManage.Instance.nightNo)
        {
            Debug.Log("HI");
        }
    }
}
