using System.Security.Cryptography;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class extralives : MonoBehaviour
{
    private TextMeshProUGUI coinText;
    void Start()
    {
        coinText = GameObject.FindWithTag("CoinText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player  player = collision.gameObject.GetComponent<Player>();
            player.heal(10);
            coinText.text = player.coins.ToString();
            Destroy(gameObject);
        }
    }
}
