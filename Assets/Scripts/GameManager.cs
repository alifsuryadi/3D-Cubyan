using UnityEngine;
//Change adegan, reload, dll
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    //Delay
    public float restartDelay = 2f;

    //UI Game over
    public GameObject CompleteLevelUI;


    //public = supaya muncul di file cs lain
    public void CompleteLevel()
    {
        //Debug.Log("Level Won");

        //Aktifkan dulu
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        //statement supaya game over tidak bertubi2
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");

            /*restrat game
            Restart();*/

            //Delay, "Restart" = panggil void Restart
            Invoke("Restart", restartDelay);
            
        }
        
    }

    void Restart()
    {
        /*Jika ingin loadScene tertentu
        SceneManager.LoadScene("Level01");*/

        //loadScene yang sedang aktif
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
