using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SS_Ham: MonoBehaviour
{
    public int Monster = 4;
    void OnTriggerEnter(Collider other)
    {
        manageDeath();
    }
    public void manageDeath()
    {
        Cursor.lockState = CursorLockMode.None;
        GameManager.Instance.TimetoDie(Monster);
    }
}
