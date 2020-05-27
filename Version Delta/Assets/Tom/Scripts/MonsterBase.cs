using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TOM
{
    public abstract class MonsterBase : MonoBehaviour
    {
        int level;


        public void Init(int lvl)
        {
            level = lvl;
        }

        //Our new Update
        public virtual void Tick(float deltaTime)
        {
            Debug.Log("Tick");
        }

        protected void Kill()
        {

        }
    }
}
