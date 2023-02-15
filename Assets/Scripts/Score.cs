using UnityEngine;
//Ubah tulisan di UI mengikuti program
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //GameObject = informasi semua tentang player
    //Transform = informasi posisi
    public Transform player;

    public Text scoreText;
    
    void Update()
    {
        /*Menghitung seberapa jauh player bergerak ke Z
        Debug.Log(player.position.z);*/


        //Ubah teks, disini kamu juga bisa ubah font, dll
        //float = data dasar
        //ToString = conver apapun ke string
        //("0") = Fungsi 0 supaya desimalnya tidak terhitung
        scoreText.text = player.position.z.ToString("0");
    }
}
