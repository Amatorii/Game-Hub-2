﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData Instance;
    public static int murdertime; //Keeps track of who is about to kill

    void Awake()
    {
        if (Instance != null || Instance != this)
            Destroy(this.gameObject);

        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetMurderTime(int i){
        murdertime = i;
    }

}
