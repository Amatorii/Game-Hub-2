using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float mouseSensitivity = 2.0f;
    public Camera firstPersonCam;

    float rotatePitch;
    float pitchRange = 60.0f;
    float rotateYaw;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        CameraMovement();
    }

    void Movement()
    {
       // direction = transform.rotation * direction;
    }

    void CameraMovement()
    {
        rotateYaw += Input.GetAxis("Mouse X") * mouseSensitivity;
        rotateYaw = Mathf.Clamp(rotateYaw, -110, 90);

        //transform.Rotate(0, rotateYaw, 0);

        rotatePitch += -Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotatePitch = Mathf.Clamp(rotatePitch, -pitchRange, pitchRange);


        //firstPersonCam.transform.Rotate(rotatePitch, 0, 0);
        firstPersonCam.transform.localRotation = Quaternion.Euler(rotatePitch, rotateYaw, 0);
    }
}
