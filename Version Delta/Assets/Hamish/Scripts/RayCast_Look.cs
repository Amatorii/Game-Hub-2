using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast_Look : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
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
        if(Physics.Raycast(camRay, out hit))
        {
            ISeeYou Exlamation = hit.transform.GetComponent<ISeeYou>();
            if (Exlamation != null)
            {
                Exlamation.Seen();
            }
        }
    }
}
