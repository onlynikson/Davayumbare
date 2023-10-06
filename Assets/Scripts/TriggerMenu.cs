using UnityEngine;

public class TriggerMenu : MonoBehaviour
{
    public AudioSource menu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        menu.Play();
    }
}
