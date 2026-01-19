using UnityEngine;

public class ObstacleSprings2 : MonoBehaviour
{
    // Attributes
    // public
    public float springForce = 40;

    // private
    Rigidbody playerRigidbody;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            playerRigidbody.linearVelocity = Vector3.zero;
            playerRigidbody.AddForce(-Vector3.forward * springForce);
            print("Por qué no va");
        }

    }
    private void Start()
    {
        Debug.DrawRay(transform.position, -Vector3.forward, Color.green);
    }
}
