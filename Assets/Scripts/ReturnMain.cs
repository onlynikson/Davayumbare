using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMain : MonoBehaviour
{
    public void SceneBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
