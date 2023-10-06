using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public int health;
    public int maxHealth = 1;
    [SerializeField] private Animator anim;
    public static event Action OnPlayerDeath;
    [SerializeField] private AudioSource fatality;
    





    public void Start()
    {
        health = maxHealth;
        anim = GetComponent<Animator>();
    }

   

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {

            Die();
            OnPlayerDeath?.Invoke();


        }


    }
 
    public void Die()
    {
        fatality.Play();
        anim.SetTrigger("Death");
    }

  


}

