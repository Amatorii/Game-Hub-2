using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher2 : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Main Menue");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Monsters");
    }
}