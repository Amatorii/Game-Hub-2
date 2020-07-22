using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time_Test : MonoBehaviour
{
    // Start is called before the first frame update
    public float startTime = 60;
    public Text textBox;

    void Start()
    {

        textBox.text = startTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;
        textBox.text = Mathf.Round(startTime).ToString();
        
    }
}
