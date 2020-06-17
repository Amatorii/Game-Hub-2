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


    //public virtual 
    public override void Init()
    {
        canKill = false;
    }

    public override void Tick(float deltaTime)
    {
        //working Debug.Log(Mymurdertime);
        base.Tick(deltaTime);
        if(Mymurdertime <= timeCheck)
        {
            // working Debug.Log("MURDER");
            canKill = true;
        }    
    }

    public override float Kill()
    {
        //if(canKill == true){Debug.Log("omaewamoshindeiru");}if (canKill == false){ Debug.Log("waiting"); } //working
        //Debug.Log("I've done my waiting, 12 years of it, in askiban"); //working
        return base.Kill();
    }


}
