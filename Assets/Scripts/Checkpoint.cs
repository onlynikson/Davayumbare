using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private AudioSource checkpointSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            ResoawnScipt.lastCheckPointPos = transform.position;
            anim.SetTrigger("appear");
            checkpointSound.Play();
        }
    }

}
