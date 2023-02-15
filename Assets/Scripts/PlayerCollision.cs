using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //Supaya player, ketika menabrak berhenti bergerak
    public PlayerMovement Movement;

    /*GameManager akan hilang otomatis ketika player hilang / menjadi prefabs
    public GameManager gameManager; */

    //Buat object bertabrakan
    private void OnCollisionEnter(Collision collisionInfo)
    {
        /*Menampilkan nama yang ditabrak
        Debug.Log(collisionInfo.collider.name);*/

        //Supaya ketika menabrak ground, tidak terbaca
        //collisionInfo.collider.(tergantung kita, bisa name or dll)
        if(collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("We hit an obstacle!");
            Movement.enabled = false;  //atau bisa = GetComponent<PlayerMovement>().enabled = false;

            //Supaya pindah ke GameManager
            FindObjectOfType<GameManager>().EndGame(); //Syntax = GetComponent<nama komponen>;
        }
    }
}
