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
        }
        else
        {
            isMoving = false;
        }
        lastPos = transform.position.x;
    }

    public override void Tick(float deltaTime)
    {
        if (Mymurdertime > GameManager.Instance.nightNo)
        {
            return;
        }
        CzecTimer();
            BenedickSounds.clip = walking;
            if(isMoving == true)
                {
                    if(!BenedickSounds.isPlaying)
                        BenedickSounds.Play();
                    Debug.Log("Benedick is walking");
                }
             else
            {
                BenedickSounds.Stop();
                Debug.Log("Benedick isn't walking");
            }
        ChecMoving();
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
        Debug.Log("You can wake up");
    }
}
