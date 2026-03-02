using System.Security.Cryptography;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class hasupgrade : MonoBehaviour
{
    private TextMeshProUGUI upgrade;
    void Start()
    {
        upgrade = GameObject.FindWithTag("pwr").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter2D(Collider2D collision)
        {
            
        
        if(collision.gameObject.tag == "Player")
        {
            Player  player = collision.gameObject.GetComponent<Player>();
            coinText.text = player.coins.ToString();
            Destroy(gameObject);
        }
        }
    }
}
