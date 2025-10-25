
using UnityEngine;

public class ControllableJoint : MonoBehaviour
{
    public float rotationSpeed = 100f;

    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward, rotX);
    }
}
