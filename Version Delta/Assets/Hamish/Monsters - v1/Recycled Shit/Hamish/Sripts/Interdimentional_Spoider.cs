using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interdimentional_Spoider : MonoBehaviour
{

    //KillCommand - Tells the player that they have died
    //Dtimer - Time till the player dies

    // Start is called before the first frame update
    void Start()
    {
        //Night check - Checks that the monster is active, night 3 onwards
        //start Dtimer
    }

    // Update is called once per frame
    void Update()
    {
        //Timer check - Check the timer to see if it's killing time, if timer = 0, trigger KillComand
    }

    void Dtimer()
    {
        //Timer - Random gen (240-180 to 0)
        //If timer Reset = true, restart timer
    }

    void KillComand()
    {
        //If KillComand = true, initiate death
    }

    void CreepyCrawlly()
    {
        //Every 20 seconds trigger creeking sound
        //If timer is = 5, trigger the licking of lips
    }

}
