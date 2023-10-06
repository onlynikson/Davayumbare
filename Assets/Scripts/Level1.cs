using UnityEngine;
using UnityEngine.SceneManagement;
public class Level1 : MonoBehaviour
{
  
    public void PlayGame()
    {
        SceneManager.LoadScene("Level Choosing");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("VaAAX");
        
    }
}
