using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelChoosed : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject level;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 1f;
        level.SetActive(true);
        player.SetActive(false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
