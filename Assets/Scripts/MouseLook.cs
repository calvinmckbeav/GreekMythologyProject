using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    Transform playerBody;
    public float mouseSensitivity = 10;
    public static bool active;
    float pitch = 0;

    void Start()
    {
        playerBody = transform.parent.transform;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        active = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            float moveX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float moveY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            //yaw
            playerBody.Rotate(Vector3.up * moveX);

            //pitch
            pitch -= moveY;

            pitch = Mathf.Clamp(pitch, -90f, 90f);
            transform.localRotation = Quaternion.Euler(pitch, 0, 0);
        }

    }
}
