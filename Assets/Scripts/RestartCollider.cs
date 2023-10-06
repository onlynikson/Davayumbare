using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Restart");
    }
}
