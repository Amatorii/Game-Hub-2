using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TOM
{
    public abstract class MonsterBase : MonoBehaviour
    {
        protected int level; 
        
        // protected = All inherited can see
        // private = Only this can see
        // public = any scripts can see


        public abstract void Init(int lvl);
        //Abstract meanse all inherited have to overide and deal with function


        //Our new Update
        public virtual void Tick(float deltaTime)
        {
            Debug.Log("Tick");
        }
        //Virtual means they either do what is here. Or override
        //They can call the origal function inside themself


        protected void Kill()
        {

        }
    }
}
