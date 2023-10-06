using UnityEngine;

public class WomanTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource woman;
 
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        woman.Play();
    }
}
