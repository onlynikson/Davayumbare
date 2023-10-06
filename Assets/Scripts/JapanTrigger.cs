using UnityEngine;

public class JapanTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource japan;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        japan.Play();
    }

   
}
