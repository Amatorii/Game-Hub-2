using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_Boi : MonoBehaviour
{
    // Start is called before the first frame update
    //Idle timer
    //Wimdow Timer
    void Start()
    {
      //Run window and Idle timer  
    }

    // Update is called once per frame
    void Update()
    {
        //Check if Window timer = 0
        //Check if Idle timer = 0
        //If player is looking at Window zone, pause timer and reset player idle timer
        //If player isn't looking at Window zone, play idle timer
    }

    void IdleTime ()
    {
        //Start timer
    }

    void WindowTime ()
    {
        //If Idle timer = 0
        //Start Window timer
        //If WindowTime = 0, initiate Death
        //Whilst WindowTime run = true, play window open
        //If player is looking at Window zone, pause timer and player idle timer
    }
}
