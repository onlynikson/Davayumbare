using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public int sceneIndex;

    public void OpenScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }

}