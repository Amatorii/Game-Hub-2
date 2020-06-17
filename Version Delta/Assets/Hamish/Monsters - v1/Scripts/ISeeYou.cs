using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISeeYou : MonoBehaviour
{
    public Move move;

    public void Seen()
    {
        Debug.Log("Seen");
        move.StopMove();
    }
       

}
