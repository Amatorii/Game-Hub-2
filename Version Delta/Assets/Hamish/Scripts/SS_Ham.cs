using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SS_Ham: MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene(1);
    }
}
