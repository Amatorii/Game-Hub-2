using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManage Instance;
    public MonsterFAB[] monsters;
    public int murdertime = 0;//Keeps track of who is about to kill
    public float nightNo = 0;
    float deltaTime;
    public float rollcall;

    void Start()
    {
        if(Instance != null)
        {
            Debug.LogError("This is getting out of hand, Now we have" + Instance.gameObject);
        }
        Instance = this;
        for (int i = 0; i < monsters.Length; i++)
        {
            monsters[i].Init();

        }
        murdertime = 0;
        nightNo = 0;
    }

    public float Nights(float nightNo)
    {
        this.nightNo = nightNo;
        return  0;
    }


    public void TimetoDie(int murderTime)
    {
        this.murdertime = murderTime;
        if(murderTime == 0)
        {
            Debug.Log("It's chill");//working
        }
        if(murderTime == 5) 
        {
            Debug.Log("Albert is the Man");//working
        }
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime = Time.deltaTime;
        for (int i = 0; i < monsters.Length; i++)
        {
            monsters[i].Tick(deltaTime);
        }
        TimetoDie(murdertime);
        Nights(nightNo);
        //nightNo += 1 * Mathf.CeilToInt(deltaTime); //to get time working with delta time (how much time has passed since called)
        
    }

}
