using UnityEngine;
using System.Collections;

public class SideScrollerMove : MonoBehaviour {

    public float movementSpeed = 5.0f;
    public float jumpSpeed = 5.0f;
    float verticalVelocity = 0;

    CharacterController cc;
    public SideScrollerCamera cam;

	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;
        verticalVelocity += Physics.gravity.y * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && cc.isGrounded)
        {
            verticalVelocity = jumpSpeed;
        }
        Vector3 speed = new Vector3(sideSpeed, verticalVelocity, 0);

        cc.Move(speed * Time.deltaTime);
	}
}
