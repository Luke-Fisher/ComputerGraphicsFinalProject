using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    public float mouseSensitivity = 500f;
    public float rotation = 0f;
    public Transform playerBody;
    public Transform firePosition;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
        firePosition.localRotation = Quaternion.Euler(rotation, 0f, 0f);
    }
}
