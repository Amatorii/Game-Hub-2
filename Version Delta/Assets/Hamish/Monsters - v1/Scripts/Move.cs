using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    bool moving = true; //Tells the object it can move
    public float startingtime = 2; //the base time for the monster's patience
    float currenttime; //The current time the monster has to wait
    public float Movespeed = 5;//how fast he moves
    public Transform resetPoint;

    public void StopMove() //makes the monster stop (interacts from other code)
    {
        Debug.Log("stop");
        moving = false;
        transform.position = resetPoint.position;
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
            currenttime -= 1 * Time.deltaTime; //subtracts how long the monster has to wait by the in game time
            if (currenttime <= 0)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Movespeed); //makes the monster move foward
            }
        }
    }

    void Start()
    {
        currenttime = startingtime; //restets the timer
    }

    // Update is called once per frame
    void Update() //He's always on the go unless told to
    {
        Moving();
        moving = true;
    }
}