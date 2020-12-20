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
    float lastPos;
    bool isMoving = false;

    public override void Init() 
    {
        lastPos = transform.position.x;
        if(Mymurdertime > GameManager.Instance.nightNo)
        {
            return;
        }
        Debug.Log("Benedick Says Hi");
        minValue = -9 * Mathf.Atan((0.9f * agression) - 4) + 15;
        maxValue = -18 * Mathf.Atan((0.2f * agression) - 0.5f) + 35;
        Left();
        Vector3 pos = transform.position;
    }

    public void Start()
    {
        Anim = GetComponent<Animator>();
        lastPos = transform.position.x;
    }

    public void ChecMoving()
    {
        if(lastPos != transform.position.x)
        {
            isMoving = true;
            Debug.Log("He shmovin");
        }
        else
        {
            isMoving = false;
            Debug.Log("No Shmovement");
        }
        lastPos = transform.position.x;
    }

    public override void Tick(float deltaTime)
    {
        ChecMoving();
        if (Mymurdertime > GameManager.Instance.nightNo)
        {
            return;
        }
        CzecTimer();
            BenedickSounds.clip = walking;
            if(isMoving == true && playingAudio == false && currentTime <=0)
                {
                playingAudio = true;
                BenedickSounds.Play();
                Debug.Log("Playing");
                }
             else
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

    void CheckForDeath()
    {
        checkForDeath = true;
    }

    public void Nani()
    {
        currentTime = -30;
    }

    void Killing()
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
        Anim.SetBool("checking", checking);
        currentTime = Random.Range(minValue, maxValue);
        checkForDeath = false;
    }
}
