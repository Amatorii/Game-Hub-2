using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Albert : MonsterFAB
{
    public bool moving = true; //Tells the object it can move
    public float startingtime; //the base time for the monster's patience
    float currenttime; //The current time the monster has to wait
    public float Movespeed = 5;//how fast he moves
    public Transform resetPoint;
    private bool seenmaybe;
    public void Moving()
    {
        if (moving == false)
        {
            currenttime = startingtime; //lazy way to stop the monster from moving
        }
        else
        {
            currenttime -= Time.deltaTime; //subtracts how long the monster has to wait by the in game time
            if (currenttime <= 0)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Movespeed); //makes the monster move foward
            }
        }
    }
    public override void Tick(float deltaTime)
    {
        Moving();
        seenquestion();
    }

    public override void seenquestion()
    {
            moving = false;
            transform.position = resetPoint.position;
    }

    //public virtual 
    public override void Init()
    {
        Debug.Log("Albert is here!");
        startingtime = Mathf.Pow(1.9f, 5.6f - 0.14f * GameManager.Instance.nightNo) + 5;
        currenttime = startingtime;
        canKill = false;
    }
}

