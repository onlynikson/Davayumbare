using UnityEngine;


public class Audio : MonoBehaviour
{

    [SerializeField] private AudioSource mivechvie;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        mivechvie.Play();
    }
}
