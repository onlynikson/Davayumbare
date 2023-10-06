using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody2D rb;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            Die();
            
        }
    }

    void Die()
    {
        
        anim.SetTrigger("death");
    }

    void RestartScene()
    {
        SceneManager.LoadScene("Level2Restart");
    }
}
