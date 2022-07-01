using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rb;
    public float forwF = 400f;
    public float sideF = 400f;

    void Start()
    {

    }


    void FixedUpdate()
    {
        Rb.AddForce(0, 0, forwF * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            Rb.AddForce(sideF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sideF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Rb.position.y < -1f)
        {
            FindObjectOfType<GM>().EndGame();
        }
    }
}