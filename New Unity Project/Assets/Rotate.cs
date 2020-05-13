using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour
{

    public Vector3 RotateAmount;

    void Update()
    {
        transform.Rotate(RotateAmount * Time.deltaTime);
    }
}