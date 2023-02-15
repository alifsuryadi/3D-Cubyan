using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        //Load game sesuai urutan "scenes in builds" di build setting
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
