using UnityEngine;

public class Audio3 : MonoBehaviour
{
    [SerializeField] private AudioSource dagvadzinera;
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        dagvadzinera.Play();
    }
}
