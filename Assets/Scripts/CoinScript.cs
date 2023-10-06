using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public AudioClip shotascoin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            AudioSource.PlayClipAtPoint(shotascoin,transform.position);
            Destroy(collision.gameObject);
        }
    }
}
