using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float raycastReach = 2;
    public float playerSpeed = 5;
    Rigidbody playerRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Debug.DrawLine(new Vector3(transform.position.x, transform.position.y, transform.position.z + transform.localScale.z / 2),
                        new Vector3(0, 0, raycastReach), Color.red);

        //print("Velocidad: " + playerRigidbody.linearVelocity);
    }
    void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, transform.forward, raycastReach))
        {
            if (playerRigidbody.linearVelocity.z >= 0)
                playerRigidbody.linearVelocity -= Vector3.forward;
            else
                playerRigidbody.linearVelocity = Vector3.zero;
        }
        else
            playerRigidbody.linearVelocity = Vector3.forward * playerSpeed;

    }
}
