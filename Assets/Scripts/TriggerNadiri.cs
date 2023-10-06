using UnityEngine;

public class TriggerNadiri : MonoBehaviour
{
    public AudioSource nadiri;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nadiri.Play();
    }

}
