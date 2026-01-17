using UnityEngine;

public class ObstacleBoost : MonoBehaviour
{
    // Attributes
    // public
    public float speedBoost = 10;

    // private
    Rigidbody objectIn = null;

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    private void OnTriggerEnter(Collider other)
    {
        objectIn = other.GetComponent<Rigidbody>();
    }

    private void OnTriggerExit(Collider other)
    {
        objectIn = null;
    }

    void FixedUpdate()
    {
        if (objectIn != null)
            objectIn.AddForce(objectIn.linearVelocity * speedBoost);
    }
}
