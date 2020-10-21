using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager Instance;
    public MonsterFAB[] monsters;
    public int nightNo;
    public LevelData[] levelData;
    float deltaTime;
    public float rollcall;
    public string game2DSceneName;
    public int DeathNo;
    public bool GameRunning;
    void Start()
    {
        if (Instance != null)
        {
            Debug.LogError("This is getting out of hand, Now we have" + Instance.gameObject);
            Destroy(this.gameObject);
        }
        Instance = this;
        nightNo = 1;
        Init();
    }

    public void Init()
    {
        GameRunning = true;
        //Debug.Log(levelData[nightNo-1].AlbertLevel);

        for (int i = 0; i < monsters.Length; i++)
         {
             monsters[i].Init();
         }
  //      GameData.Instance.murdertime = 0;
        Load2DGame();
    }

    public void Gamewin()
    {
        nightNo++;
        if(nightNo <= levelData.Length)
        {
            Load2DGame();
        }
        else
        {
            nightNo = 0;
            Load2DGame();
        }
        Debug.Log("Night Completed");
        Init();
    }

    public void Load2DGame()
    {
       SceneManager.LoadSceneAsync(levelData[nightNo - 1].GameLevel, LoadSceneMode.Additive);
    } 

    void unload2dGame()
    {
        
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

    public void GameOver()
    {
        
    }

    public void TimetoDie(int murderTime)
    {
        GameRunning = false;
        GameData.Instance.murdertime = murderTime;
        if (murderTime == 0)
        {
           Debug.Log("It's chill");//working
        }
        if(murderTime != 0)
        {

        }
        if(murderTime == 1)
        {
            Debug.Log("Spud Says Hi");
            //Spud's Scene "Refuse to be defined by the opinions and coersions of others"
        }
        if(murderTime == 2)
        {
            Debug.Log("Eye spy ur gonna die");
            //Yamez's scene "Refuse to be defined by your greatest fears"
        }
        if(murderTime == 3)
        {
            Debug.Log("Benedick Says goodnight");
            //Benedick's Scene "Refuse to be defined by domestic abuse and expectation"
        }
        if (murderTime == 4)
        {
            Debug.Log("Albert is the Man");
            //working
            //SceneManager.LoadScene(1); Albert's Scene "Refuse to be defined by the worst of you"
        }
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        deltaTime = Time.deltaTime;
         for (int i = 0; i < monsters.Length; i++)
         {
             monsters[i].Tick(deltaTime);
         }
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
    


