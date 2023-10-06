using UnityEngine;

public class FireSound : MonoBehaviour
{
    [SerializeField] private AudioSource fire;
   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        fire.Play();
    }
}
