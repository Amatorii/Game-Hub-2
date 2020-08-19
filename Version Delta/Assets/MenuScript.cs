using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int define;
    public Text deathText;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        MurderText();
    }

    public void MurderText()
    {
        this.define = GameData.Instance.murdertime;
        Debug.Log(define);
        if(define == 1)
        {
            deathText.text = "Refuse to be defined by the opinions and coersions of others";
        }
        else if (define == 2)
        {
            deathText.text = "Refuse to be defined by your greatest fears";
        }
        else if (define == 3)
        {
            deathText.text = "Refuse to be defined by domestic abuse and pressure";
        }
        else if (define == 4)
        {
            deathText.text = "Refuse to be defined by the worst of you";
        }
        else
        {
            deathText.text = "Something is wrong";
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
