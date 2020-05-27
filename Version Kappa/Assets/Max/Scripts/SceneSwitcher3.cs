using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher3 : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Main Menue");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}