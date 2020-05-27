using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TOM
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        public float gameTime;
        public LevelInfo levelInfo;

        public bool pause;

        public MonsterBase[] monsters;

        public MonsterCloset mc;

        void Start()
        {
            if (Instance != null)
                Destroy(this); // We have a version of the GameManager already, remove!
            Instance = this;
        }

        // Update is called once per frame
        void Update()
        {
            if (pause == true)
                return;

            float time = Time.deltaTime;
            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i].Tick(time);
            }
        }
    }
}
