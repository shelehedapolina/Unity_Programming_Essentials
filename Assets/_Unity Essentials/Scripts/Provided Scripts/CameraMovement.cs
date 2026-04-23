using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float lookSpeed = 2f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * lookSpeed;
        rotationX -= Input.GetAxis("Mouse Y") * lookSpeed;

        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);

        float moveForward = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float moveSide = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate(moveSide, 0, moveForward);
    }
}
