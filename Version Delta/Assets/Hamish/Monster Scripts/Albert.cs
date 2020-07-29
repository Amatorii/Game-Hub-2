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
            currenttime = startingtime; //lazy way to stop the monster from moving
            //Debug.Log("Not Moving - A");
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
        Moving();
        moving = true;
    }
    public void Chant()
    {
            AlbertSounds.clip = AlbertChant;
            AlbertSounds.Play();
            Debug.Log("He Be Singing");
    }

    public override void seenquestion()
    {
            moving = false;
    }

    //public virtual 
    public override void Init()
    {
        startingtime = 1;
        //startingtime = Mathf.Pow(1.9f, 5.6f - 0.14f * GameManager.Instance.nightNo) + 5;
       Debug.Log("Albert is here! I'm going to wait for " + startingtime);
        currenttime = startingtime;
        canKill = false;
        Chant();
    }
}

