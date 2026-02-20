using System.Security.Cryptography;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    private TextMeshProUGUI coinText;
    private void Start()
    {
        coinText = GameObject.FindWithTag("CoinText").GetComponent<TextMeshProUGUI>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player  player = collision.gameObject.GetComponent<Player>();
            player.coins += 1;
            coinText.text = player.coins.ToString();
            Destroy(gameObject);
        }
    }
}
