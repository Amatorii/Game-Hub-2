using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public abstract class MonsterFAB : MonoBehaviour
{
    public Animator MstAnime; //Animation for movement
    protected float Timer = 10; //Base timer
    protected float Ctimer;
    protected float timeCheck;
    public int monsterActive; //Is it active
    protected int deltaTime;
    public int Mymurdertime; //Sets it's murder No. to send to the game manager
    protected bool canKill; //the script knows it can kill
    public int aggression;
    public abstract void Init();

    public virtual void Tick(float deltaTime) //It's private version of time
    {
        timeCheck += deltaTime;
        if ()
        {
            Kill();
            Activity();
        }
        //Functionallity Goes here
    }


        public virtual float Kill()
        {
             if(timeCheck >= Mymurdertime)
            {
            canKill = true;
            Debug.Log("It's time to begin"); //working
            }
             if(canKill == true)
            {
            Debug.Log("Isn't it?"); //woring
                GameManage.Instance.TimetoDie(Mymurdertime);
            }
        //Debug.Log("I've done my waiting, 12 years of it, in askiban"); //working?
        return 0;
        }

    public virtual void Activity()
    {
        if(Mymurdertime == GameManage.Instance.nightNo)
        {
            Debug.Log("HI");
        }
    }
}
