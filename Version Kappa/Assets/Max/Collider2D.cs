using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        Debug.Log("Enter Called");
    }

    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        Debug.Log("Stay Touching: " + collision.gameObject.name);
    }
    private void OnTriggerExit2D(UnityEngine.Collider2D collision)
    {
        Debug.Log("Exit Called");
    }
}
