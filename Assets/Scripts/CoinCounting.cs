using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class CoinCounting : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] private Text coinText;

    private void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinText.text = "COINS : " + coins;

        }
    }
}
