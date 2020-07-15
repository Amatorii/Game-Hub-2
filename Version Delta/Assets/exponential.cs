using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exponential : MonoBehaviour
{
    int currenttime = 1;
    public int Testno = 5;
    // Start is called before the first frame update
    void Start()
    {
        expon();
    }
    private void expon()
    {
        //currenttime = Mathf.Pow(1.9f, 6 - (0.14f * Testno)) + 5;
        Debug.Log(currenttime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
