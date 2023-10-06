using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelChoosing : MonoBehaviour
{
    [SerializeField] private GameObject choose;
    
   public void GameOn()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Level2()
    {
        choose.SetActive(false);
        SceneManager.LoadScene("Level2");
    }

    public void Level2Choose()
    {
        choose.SetActive(true);
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
