using UnityEngine;

public class EnemyHurting : MonoBehaviour
{

    [SerializeField] private float health;
    [SerializeField] private float maxHealth;

    private void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if(health < 0)
        {
            Destroy(gameObject);
        }
    }
}
