﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UWEEN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.Instance.Gamewin();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
