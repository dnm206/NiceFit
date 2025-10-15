using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); 
        Vector3 movement = new Vector3(moveX, 0, 0) * moveSpeed;
        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, rb.linearVelocity.z);
    }
}
