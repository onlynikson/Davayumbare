
using UnityEngine;

public class PlayerKilling : MonoBehaviour
{
   
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<EnemyHurting>(out EnemyHurting enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }
        Destroy(gameObject);





    }
}
