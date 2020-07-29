using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast_Look : MonoBehaviour
{
    public Camera cam;
    flashlight Light; 
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        Light = GetComponent<flashlight>();
    }

    // Update is called once per frame
    void Update()
    {
        DoRaycast();
    }

    void DoRaycast()
    {
        RaycastHit hit;
        Ray camRay = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        Debug.DrawLine(cam.transform.position, cam.transform.forward * 100, Color.red);

        if(Physics.Raycast(camRay, out hit))
        {
            ISeeYou Exlamation = hit.transform.GetComponent<ISeeYou>();
            if (Exlamation != null && Light.FlashLightOn==true)
            {
                Exlamation.See();
                Debug.Log("checked");
            }
        }
    }



}
