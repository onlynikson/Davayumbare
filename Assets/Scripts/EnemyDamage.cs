using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private Damage damageHealth;
    [SerializeField] private GameObject player;









    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            damageHealth.TakeDamage(1);
            







        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }
    

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
