using UnityEngine;
using UnityEditor.SceneManagement;

public class start : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Levels");
        Time.timeScale = 1;
    }
}
