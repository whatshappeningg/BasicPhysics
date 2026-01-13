using UnityEngine;

public class ObstacleMud : MonoBehaviour
{
    // Attributes
    // public
    public float dampingAdded = 7;

    // private

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.brown;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().linearDamping = dampingAdded;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Rigidbody>().linearDamping = 0;
    }
}
