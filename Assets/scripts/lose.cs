using UnityEngine;

public class lose : MonoBehaviour
{
    public void LoadHell()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        Time.timeScale = 1;
    }
}
