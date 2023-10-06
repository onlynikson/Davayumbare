using UnityEngine;
using UnityEngine.SceneManagement;

public class Volume : MonoBehaviour
{
    [SerializeField] private AudioSource sound;
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sound.Play();
    }
}
