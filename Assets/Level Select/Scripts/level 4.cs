using UnityEngine;
using UnityEditor.SceneManagement;

public class level4 : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level4");
        Time.timeScale = 1;
    }
}
