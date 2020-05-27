using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TOM
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        void Start()
        {
            if (Instance != null)
                Destroy(this); // We have a version of the GameManager already, remove!
            Instance = this;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
