using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher3 : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Monsters");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Monsters");
    }
}