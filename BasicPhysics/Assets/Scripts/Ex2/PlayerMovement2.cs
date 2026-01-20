using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float raycastReach = 2;
    public float playerSpeed = 5;
    Rigidbody playerRigidbody;
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

    void Update()
    {
        //print("Velocidad: " + playerRigidbody.linearVelocity);
    }
    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastReach))
        {
            Debug.DrawLine(new Vector3(transform.position.x, transform.position.y, transform.position.z + transform.localScale.z / 2),
                        hit.point, Color.red);

            if (playerRigidbody.linearVelocity.z > 0)
                playerRigidbody.linearVelocity -= Vector3.forward;
            else
                playerRigidbody.linearVelocity = Vector3.zero;
        }
        else if (groundContact)
            playerRigidbody.linearVelocity = Vector3.forward * playerSpeed;
        else
            playerRigidbody.linearVelocity = Vector3.zero;

    }
}
