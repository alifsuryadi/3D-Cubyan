using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    //OnTriggerEnter = supaya bisa menjadi pemicu
    void OnTriggerEnter()
    {
        //gameManager = supaya bisa memanggil semua function di gameManager
        gameManager.CompleteLevel();
    }

}
