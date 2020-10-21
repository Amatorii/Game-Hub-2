using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Benedick : MonsterFAB
{
    public float startTime = 5;
    public float currentTime;
    public PlayerCamera gamer;
    public Animator Anim;
    public bool checking;
    public bool checkForDeath;
    public AudioSource BenedickSounds;
    public AudioClip walking;
    public bool playingAudio;
    public override void Init()
    {
        if(Mymurdertime > GameManager.Instance.nightNo)
        {
            return;
        }
        Debug.Log("Benedick Says Hi");
        minValue = -9 * Mathf.Atan((0.9f * agression) - 4) + 15;
        maxValue = -18 * Mathf.Atan((0.2f * agression) - 0.5f) + 35;
        Left();
    }

    public void Start()
    {
        Anim = GetComponent<Animator>();
    }

    public override void Tick(float deltaTime)
    {
        if (Mymurdertime > GameManager.Instance.nightNo)
        {
            return;
        }
        CzecTimer();
        BenedickSounds.clip = walking;
        if(checking == true && playingAudio == false)
        {
            playingAudio = true;
            BenedickSounds.Play();
            Debug.Log("Playing");
        }
        else if(checking == false && playingAudio == true)
        {
            playingAudio = false;
            BenedickSounds.Stop();
            Debug.Log("Stop");
        }
    }

    public void CzecTimer()
    {
        currentTime -= Time.deltaTime;
        if(currentTime <= 0 && checking == false)
        {
            checking = true;
            Anim.SetBool("checking", checking);
            
        }
        if(checkForDeath == true)
        {
            Killing();
        }
    }

    public void CheckForDeath()
    {
        checkForDeath = true;
    }

    public void Nani()
    {
        currentTime = -30;
    }

    public void Killing()
    {
        if (gamer.sleeping == false)
        {
            Kill();
        }
        else
        {
            Debug.Log("U no dead");
        }
    }

    public void Left()
    {
        checking = false;
        currentTime = Random.Range(minValue, maxValue);
        checkForDeath = false;
        Debug.Log(currentTime);
    }
}
