using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Levels");
        Time.timeScale = 1;
    }
}
