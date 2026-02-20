using UnityEngine;
using UnityEngine.SceneManagement;
public class level2 : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }
}
