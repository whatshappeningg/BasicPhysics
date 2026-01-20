using UnityEngine;

public class ObstacleSprings_V : MonoBehaviour
{
    // Attributes
    // public
    public float springForce = 100;

    // private
    Rigidbody objectIn = null;

    private void OnTriggerEnter(Collider other)
    {
        objectIn = other.GetComponent<Rigidbody>();

        objectIn.linearVelocity = Vector3.zero;
        objectIn.AddForce(Vector3.up * springForce, ForceMode.Impulse);
    }
}
