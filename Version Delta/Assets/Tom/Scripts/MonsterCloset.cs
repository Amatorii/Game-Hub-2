using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TOM
{
    public class MonsterCloset : MonsterBase
    {
        bool moving = true;
        public float startingtime = 2;
        float currenttime;
        public float Movespeed = 5;

        public override void Tick(float deltaTime)
        {
            Debug.Log("Plooo");
            Moving();
            moving = true;
        }

        public void StopMove()
        {
            Debug.Log("stop");
            moving = false;
        }

        private void Moving()
        {
            if (moving == false)
            {
                currenttime = startingtime;
                Debug.Log("Not Moving");
            }
            if (moving == true)
            {
                currenttime -= 1 * Time.deltaTime;
                //currenttime.ToString("0");
                if (currenttime <= 0)
                {
                    //transform.Translate(Vector3.forward * Time.deltaTime);
                    transform.Translate(Vector3.forward * Time.deltaTime * Movespeed);
                }
            }

        }


        public void Alert()
        {

        }
    }
}
