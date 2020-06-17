using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger2D : MonoBehaviour
{
    
    public void WinGame()
    {
        GameManager.Instance.EndNight();
    }
}
