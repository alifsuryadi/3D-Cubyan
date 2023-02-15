using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Transfrom = posisi
    public Transform player;

    //Bikin kamera di belakang player
    //Vektor3 = Koordinat 3D (X,Y,Z) datanya bisa int & float
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        /*player.position = mencetak setiap posisi di console
        Debug.Log(player.position);*/

        //Menyamakan posisi kamera dan player
        transform.position = player.position + offset;
    }
}
