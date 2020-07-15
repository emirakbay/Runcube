using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject obstacleprefab;
    public Rigidbody rb;


    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 500f;

    /*Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacleprefab, transform.position + Vector3.forward, Quaternion.identity);
    }*/

      /* is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 200);
    }*/


    void FixedUpdate()
    {  
        // Addd a forward force variable so that it can be manipulated over Unity Engine.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0.3f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (Input.GetKey("space"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.Impulse);

        }
    } 
}
