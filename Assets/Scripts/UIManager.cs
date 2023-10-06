using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject restart;

    private void OnEnable()
    {
        Damage.OnPlayerDeath += EnableRestartMenu;
    }

    private void OnDisable()
    {
        Damage.OnPlayerDeath -= EnableRestartMenu;
    }
    public void EnableRestartMenu()
    {
        restart.SetActive(true);
    }
}
