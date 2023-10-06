using UnityEngine;

public class AttackingArea : MonoBehaviour
{
    [SerializeField] private int damage;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Damage>() != null)
        {
            Damage health = collider.GetComponent<Damage>().GetComponent<Damage>();
            health.TakeDamage(damage);
        }
    }

    void Update()
    {
        
    }
}
