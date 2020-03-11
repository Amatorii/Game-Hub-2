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

    Transform movePoint;
    Transform pointToHit;
    public Transform[] locations;
    bool onBed = true;
    int movePlace;

    LayerMask zones;
    Camera cam;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        movePoint = locations[0];
        zones = LayerMask.GetMask("Zones");
        cam = Camera.main;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraMovement();
        Movement();
        movePlace = GetZone();
        if (Input.GetButtonDown("Jump"))
        {
            SetLocation();
        }
    }

    void Movement()
    {
        // direction = transform.rotation * direction;
        transform.position = Vector3.Lerp(transform.position, movePoint.position, 0.1f);
    }

    void SetLocation()
    {
        if (onBed == true)
        {
            if(movePlace == 1)
                 anim.SetBool("UnderBed", true);
            if (movePlace == 2)
                anim.SetBool("Wardrobe", true);

            onBed = false;
        }
        else
        {
            anim.SetBool("UnderBed", false);
            anim.SetBool("Wardrobe", false);
            onBed = true;
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

    public int GetZone()
    {
        RaycastHit hit;

        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit,Mathf.Infinity, zones))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "Bed Zone")
                return 1;
            else if (hit.transform.name == "Wardrobe")
                return 2;
            else
                return 0;
        }

        return 0;
    }
}
