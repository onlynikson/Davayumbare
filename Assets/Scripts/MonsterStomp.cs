using System.Collections;
using UnityEngine;

public class MonsterStomp : MonoBehaviour
{
    [SerializeField] private AudioSource davayumbare;
    
    void Start()
    {
       
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Weak Point")
        {
            Destroy(collision.gameObject);
            davayumbare.Play();
            
        }
    }

   
}
