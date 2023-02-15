using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Supaya bisa diatur di inspector unity
    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        //Massage
        Debug.Log("Start");

        /*Gravitasi
        rb.useGravity = false;*/

        /*Gaya or gerakan sesuai sumbu (X,Y,Z)
        rb.AddForce(0, 200, 500);*/

    }

    /* We are marked this as "Fixed"Update  because we
       are using it to mess with physics.*/
    void FixedUpdate()
    {
        /*Maka akan terus bergerak perframe
        rb.AddForce(0, 0, 200);*/

        //TimeDelta = waktu yang berlalu sejak frame sebelumnya, dalam detik
        //rb.AddForce(0, 0, 2000 * Time.deltaTime);


        //Add forwardForce untuk bisa input di unity
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        //Add statement
        //Input.GetKey = ketika user klik keyboard
        if (Input.GetKey("d"))
        {
            //ForceMode.(Pilih) = Supaya belok jadi responsive
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
