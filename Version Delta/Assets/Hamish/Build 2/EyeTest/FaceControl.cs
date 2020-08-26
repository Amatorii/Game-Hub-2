using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceControl : MonoBehaviour
{
    public MeshRenderer[] eyes;
    public int eyesClosed;
    public float timer;
    public float timeToOpen = 1;
    public Texture eyeOpen;

    void Start()
    {
        eyesClosed = eyes.Length;
        timer = timeToOpen;
    }

    void Update()
    {
        if (eyesClosed == 0)
            return;
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            eyesClosed -= 1;
            eyes[eyesClosed].material.SetTexture("_BaseMap", eyeOpen);
            timer = timeToOpen;
        }
    }
}
