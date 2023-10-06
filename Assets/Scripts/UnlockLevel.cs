using UnityEngine;
using UnityEngine.SceneManagement;




public class UnlockLevel : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            UnlockedLevel();
            SceneController.instance.NextLevel();
        }
    }

    public void UnlockedLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex>= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel",PlayerPrefs.GetInt("UnlockedLevel1", 1) + 1);
            PlayerPrefs.Save();
        }
    }

   
}
