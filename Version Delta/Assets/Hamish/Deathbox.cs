﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathbox : MonoBehaviour
{
    public Transform resetPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = resetPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
