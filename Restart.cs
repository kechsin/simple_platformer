using UnityEngine;

public class Restart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadCurrentScene()
    {
        Time.timeScale = 1f; // Reset time scale in case it was modified (e.g., on win)
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
