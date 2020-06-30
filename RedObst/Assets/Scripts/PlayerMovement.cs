using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add some forward force to the player.
        rb.AddForce(0, 0, AppModel.forwardForce * Time.deltaTime);

        // Move right
        if (Input.GetKey("d"))
            rb.AddForce(AppModel.sideForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);

        // Move left
        if (Input.GetKey("a"))
            rb.AddForce(-AppModel.sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if(rb.position.y < 0)
            FindObjectOfType<GameManager>().TryAgain();
    }
}
