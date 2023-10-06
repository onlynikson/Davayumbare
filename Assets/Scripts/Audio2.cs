using UnityEngine;

public class Audio2 : MonoBehaviour
{

    [SerializeField] private AudioSource audio2;
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audio2.Play();
    }
}
