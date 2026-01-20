using UnityEngine;

public class CameraMouseRaycaster : MonoBehaviour
{
    // Attributes
    // public
    public Camera camera1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera1.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                hit.collider.gameObject.SetActive(false);
            }
        }
    }
}
