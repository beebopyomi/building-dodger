using UnityEngine;
using UnityEngine.UI;

public class ShowImageOnHit : MonoBehaviour
{
    public Image popupImage;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            popupImage.gameObject.SetActive(true);
        }
    }
}
