using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDying : MonoBehaviour
{

    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody2D rb;


    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
       
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
            RestartScene();
        }
    }

    void Die()
    {
        anim.SetTrigger("Death");
        rb.bodyType = RigidbodyType2D.Static;
    }

  void RestartScene()
    {
        SceneManager.LoadScene("Level2Restart");
    }
   
}
