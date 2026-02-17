using Unity.VisualScripting;
using UnityEngine;

public class flag : MonoBehaviour
{
    public GameObject winUI;

    void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            winUI.SetActive(true);
        }
    }
}
