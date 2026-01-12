using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Attributes
    // public
    public float playerSpeed = 100;
    public float jumpForce = 400;

    // private
    private Rigidbody playerRigidbody;
    private bool groundContact;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            groundContact = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            groundContact = false;
    }

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        playerRigidbody.AddForce(Input.GetAxis("Horizontal") * playerSpeed, 0, Input.GetAxis("Vertical") * playerSpeed);

        if (Input.GetKeyUp(KeyCode.Space) && groundContact == true)
            playerRigidbody.AddForce(Vector3.up * jumpForce);
    }
}
