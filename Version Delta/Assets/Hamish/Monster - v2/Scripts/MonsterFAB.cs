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
    public bool awake = false;
    private int agression;
    public abstract void Init();

    public virtual void Tick(float deltaTime) //It's private version of time
    {
        timeCheck += deltaTime;
        if (awake == true)
        {
            Kill();
            Activity();
        }
        //Functionallity Goes here
    }

    private void Myagression(int agression)
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

        public virtual float Kill() //checks if it can kill
        {
             if(timeCheck >= Mymurdertime)
            {
            canKill = true;
            Debug.Log("It's time to begin"); //working
            }
             if(canKill == true)
            {
            Debug.Log("Isn't it?"); //woring
                GameManager.Instance.TimetoDie(Mymurdertime);
            }
        //Debug.Log("I've done my waiting, 12 years of it, in askiban"); //working?
        return 0;
        }

    public virtual void Activity() //It doing things
    {
        if(Mymurdertime == GameManager.Instance.nightNo)
        {
            Debug.Log("HI");
        }
    }
}
