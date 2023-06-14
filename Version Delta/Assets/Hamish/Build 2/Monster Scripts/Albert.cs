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
    public AudioSource AlbertSounds;
    public AudioClip AlbertChant;
    public AudioClip AlbertDeath;

    public void Moving()
    {
        if (moving == false)
        {
            TimerReset();
            transform.position = resetPoint.position;
        }
        if (moving == true)
        {
            currenttime -= Time.deltaTime; //subtracts how long the monster has to wait by the in game time
           // Debug.Log(currenttime + " Seconds left!");
            if (currenttime <= 0)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Movespeed); //makes the monster move foward
            }
        }
    }
    public override void Tick(float deltaTime)
    {
        if (Mymurdertime > GameManager.Instance.nightNo)
        {
            return;
        }

        Moving();
        moving = true;
        if(ActionisComing == false)
        {
            moving = false;
        }
        ActionisComing = true;
    }
    public void Chant()
    {
            AlbertSounds.clip = AlbertChant;
            AlbertSounds.Play();
    }
    //public virtual 
    public override void Init()
    {   
        if(Mymurdertime > GameManager.Instance.nightNo)
        {
            return;
        }
        Debug.Log("Albert is Active");
        TimerReset();
        Chant();
    }
    public void TimerReset()
    {
        maxValue = Mathf.Pow(2.5f, 5.3f - 0.14f * agression) - 35;
        minValue = Mathf.Pow(2.3f, 5.6f - 0.14f * agression) - 30;
        startingtime = Random.Range(minValue, maxValue);
        currenttime = startingtime;
    }
}

