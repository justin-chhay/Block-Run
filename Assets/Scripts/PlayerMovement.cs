using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    // The 'f' at the end of the values signify that the value is of the "float" data type
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this as a "Fixed" update, because we are using it to mess w/ physics. Plus, Unity prefers this
    void FixedUpdate ()
    {
        // Add a force on the z-axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   

        if ( Input.GetKey("d"))
        {
            //Only executed if condition is met
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            //Only executed if condition is met
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
