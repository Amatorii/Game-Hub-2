using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Albert : MonsterFAB
{
    public override void Activity()
    {
        if (Mymurdertime <= GameManage.Instance.nightNo)
        {
            Debug.Log("Albert says Hi"); //working
        }
        //Debug.Log("I like to move it move it");//working


    }

}

   
