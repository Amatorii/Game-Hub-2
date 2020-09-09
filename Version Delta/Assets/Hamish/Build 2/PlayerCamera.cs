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
    public bool sleeping;
    bool checkingBed;
    //Transform movePoint;
    public Transform[] locations;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        sleeping = false;
        checkingBed = false;
        Cursor.lockState = CursorLockMode.Locked;
        //movePoint = locations[0];
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }




    void Movement()
    {
        if (sleeping == false && checkingBed == false)
        {
            CameraMovement();
        }
        if (Input.GetButtonDown("Fire3") && checkingBed == false)
        {
            sleeping = !sleeping;
            anim.SetBool("Sleeping", sleeping);
        }
        if (sleeping)
        {
            firstPersonCam.transform.localRotation = Quaternion.Slerp(firstPersonCam.transform.localRotation, Quaternion.Euler(-2, 10, 0), Time.deltaTime * 5);
        }

        if(Input.GetButtonDown("Fire1") && sleeping == false)
        {
            checkingBed = !checkingBed;
            anim.SetBool("bedCheck", checkingBed);
        }
        if(checkingBed)
        {
            firstPersonCam.transform.localRotation = Quaternion.Slerp(firstPersonCam.transform.localRotation, Quaternion.Euler(0, -90, 0), Time.deltaTime * 5);
        }
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
