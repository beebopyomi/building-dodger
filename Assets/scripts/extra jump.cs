using System.Security.Cryptography;
using UnityEngine;

public class dublejump : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player  player = collision.gameObject.GetComponent<Player>();
            player.extraJumpsValue += 1;
            Destroy(gameObject);
        }
    }
}
