using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Albert : MonsterFAB
{
    bool moving = true; //Tells the object it can move
    public float startingtime; //the base time for the monster's patience
    float currenttime; //The current time the monster has to wait
    public float Movespeed = 5;//how fast he moves
    public Transform resetPoint;
    public override void Activity()
    {
        if (Mymurdertime <= GameManager.Instance.nightNo)
        {
            Debug.Log("Albert says Hi"); //working
        }
        //Debug.Log("I like to move it move it");//working

    }
    private void Moving()
    {
        if (moving == false)
        {
            currenttime = startingtime; //lazy way to stop the monster from moving
            Debug.Log("Not Moving");
        }
        if (moving == true)
        {
            currenttime -= Time.deltaTime; //subtracts how long the monster has to wait by the in game time
            if (currenttime <= 0)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Movespeed); //makes the monster move foward
            }
        }
    }
    public virtual void Tick()
    {
        Moving();
    }

    //public virtual 
    public override void Init()
    {
        canKill = false;
        startingtime = Mathf.Pow(1.9f,6-0.14f*GameManager.Instance.nightNo) + 5;
        Debug.Log(startingtime);
    }
}

