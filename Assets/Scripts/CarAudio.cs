using UnityEngine;

public class CarAudio : MonoBehaviour
{
    [SerializeField] private AudioSource car;
   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        car.Play();
        
    }
}
