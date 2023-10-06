using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public AudioSource sound2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sound2.Play();
        
    }
}
