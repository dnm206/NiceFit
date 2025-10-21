
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Các IK target cho tay, chân và đầu.
    // Bạn sẽ cần gán các object này trong Unity Editor.
    [SerializeField] private Transform headTarget;
    [SerializeField] private Transform leftHandTarget;
    [SerializeField] private Transform rightHandTarget;
    [SerializeField] private Transform leftFootTarget;
    [SerializeField] private Transform rightFootTarget;

    // Tốc độ di chuyển của các target
    [SerializeField] private float moveSpeed = 1.0f;

    private Vector2 _leftStickInput;
    private Vector2 _rightStickInput;

    // Hàm này được gọi bởi Player Input component
    public void OnLeftStick(InputAction.CallbackContext context)
    {
        _leftStickInput = context.ReadValue<Vector2>();
    }

    // Hàm này được gọi bởi Player Input component
    public void OnRightStick(InputAction.CallbackContext context)
    {
        _rightStickInput = context.ReadValue<Vector2>();
    }

    void Update()
    {
        // Di chuyển target của tay phải dựa trên right stick
        if (rightHandTarget != null)
        {
            Vector3 rightHandMovement = new Vector3(_rightStickInput.x, _rightStickInput.y, 0);
            rightHandTarget.position += rightHandMovement * moveSpeed * Time.deltaTime;
        }

        // Di chuyển target của tay trái dựa trên left stick
        if (leftHandTarget != null)
        {
            Vector3 leftHandMovement = new Vector3(_leftStickInput.x, _leftStickInput.y, 0);
            leftHandTarget.position += leftHandMovement * moveSpeed * Time.deltaTime;
        }
    }
}
