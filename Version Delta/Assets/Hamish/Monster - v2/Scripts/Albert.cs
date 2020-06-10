using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Albert : MonsterFAB
{
    public override void Activity()
    {
        if (Mymurdertime == GameManage.Instance.nightNo)
        {
            Debug.Log("HI");
        }
    }


    //public virtual 
    public override void Init()
    {
        
    }
}
