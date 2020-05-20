using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Monsters");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Game Over-Death Screen");
    }
}