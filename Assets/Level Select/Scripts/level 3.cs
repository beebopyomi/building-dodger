using UnityEngine;
using UnityEditor.SceneManagement;

public class level3 : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
        Time.timeScale = 1;
    }
}
