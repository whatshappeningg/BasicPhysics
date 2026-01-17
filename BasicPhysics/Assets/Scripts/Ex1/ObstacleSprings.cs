using UnityEngine;

public class ObstacleSprings : MonoBehaviour
{
    // Attributes
    // public
    public float springForce = 90;

    // private
    Rigidbody objectIn = null;

    private void OnTriggerEnter(Collider other)
    {
        objectIn = other.GetComponent<Rigidbody>();
        objectIn.linearVelocity = Vector3.zero;
    }

    private void OnTriggerExit(Collider other)
    {
        objectIn = null;
    }

    void FixedUpdate()
    {
        if (objectIn != null)
            objectIn.AddForce(Vector3.up * springForce);
    }
}
