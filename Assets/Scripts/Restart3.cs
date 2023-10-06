using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart3 : MonoBehaviour
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



}
