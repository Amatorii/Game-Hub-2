using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager Instance;
    public MonsterFAB[] monsters;
    public int murdertime = 0;//Keeps track of who is about to kill
    public int nightNo = 6;
    float deltaTime;
    public float rollcall;
    public string game2DSceneName;

    void Start()
    {
        nightNo = 6;
        if (Instance != null)
        {
            Debug.LogError("This is getting out of hand, Now we have" + Instance.gameObject);
        }
        Instance = this;

        
         for (int i = 0; i < monsters.Length; i++)
         {
             monsters[i].Init();
         }
         murdertime = 0;
        Load2DGame();

    }

    public void Gamewin()
    {
        SceneManager.LoadScene(5);
    }

    public void Load2DGame()
    {
        SceneManager.LoadSceneAsync(game2DSceneName, LoadSceneMode.Additive);
    }

    public float Nights(int nightNo)
    {
        this.nightNo = nightNo;
        return 0;
    }

    public void EndNight()
    {
        Debug.Log("EndNight");
    }

    public void TimetoDie(int murderTime)
    {
        this.murdertime = murderTime;
        if (murderTime == 0)
        {
           // Debug.Log("It's chill");//working
        }
        if (murderTime == 5)
        {
            //Debug.Log("Albert is the Man");//working
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
        // nightNo += 1 * Mathf.CeilToInt(deltaTime); //to get time working with delta time (how much time has passed since called)
    }

  
    
    public void FinishVGLevel(bool died = false)
    {
        if(died == true)
        { 
            //ISeeYou ded

        }
        else
        {
            //Won the game
        }
    }
    
}
    


