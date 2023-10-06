using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EnemyDamage2 : MonoBehaviour
{
    public Damage damageHealth;
    
    public GameObject player;

   

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            damageHealth.TakeDamage(1);

           



        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level2");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    


}
