using UnityEngine;

public class PlayOnTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource play;
   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        play.Play();
    }
}
