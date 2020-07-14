using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSceneChange : MonoBehaviour
{
 void OnTriggerEnter2D (Collider2D collider)
 {
        if (collider.tag == "Player")
        {
            SceneManager.LoadScene("Win");
            Debug.Log("You Win");
        }
 }
}