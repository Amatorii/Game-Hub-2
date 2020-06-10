using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManage Instance;
    public MonsterFAB[] monsters;
    public int murdertime;//Keeps track of who is about to kill
    public int nightNo = 0;

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
    }

    public void Nights(int nightNo)
    {
        this.nightNo = nightNo;
    }


    public void TimetoDie(int murderTime)
    {
        this.murdertime = murderTime;
        if(murdertime == 0)
        {
            Debug.Log("It's chill");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;
        for (int i = 0; i < monsters.Length; i++)
        {
            monsters[i].Tick(deltaTime);

        }
    }
}
