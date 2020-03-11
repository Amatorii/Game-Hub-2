using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DController : MonoBehaviour
{
    public float MovenntSpeed;
    public float jumpSpeed;
    public LayerMask groundMask;
    public Transform feetTopLeft;
    public Transform feetBottomRight;

    Rigidbody2D rb;
    float moveInput;
    bool jumpInput = false;
    bool justJumped = false;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector2 vel = rb.velocity;
        vel.x = moveInput * MovenntSpeed;
        rb.velocity = vel;
    }
}
