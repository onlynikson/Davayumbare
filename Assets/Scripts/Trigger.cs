using System.Collections;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public AudioSource sound;
    

  

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        sound.Play();

    }

 



}
