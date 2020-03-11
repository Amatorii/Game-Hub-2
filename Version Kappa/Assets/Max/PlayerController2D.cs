using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    bool flipped = false;
    SpriteRenderer characterSpriteRend;

    public float MovementSpeed;
    public float jumpSpeed;
    public LayerMask groundMask;
    public Transform feetTopLeft;
    public Transform feetBottomRight;

    Rigidbody2D rb;
    float moveInput;
    public bool jumpInput = false;
    public bool justJumped = false;

    void Start()
    {

    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetButton("Jump");
        if (moveInput < 0)
            flipped = true;
        else if (moveInput > 0)
            flipped = false;

        characterSpriteRend.flipX = flipped;
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        characterSpriteRend = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Vector2 vel = rb.velocity;
        vel.x = moveInput * MovementSpeed;
        if(jumpInput == true && justJumped == false && Physics2D.OverlapArea(feetTopLeft.position, feetBottomRight.position, groundMask) != null)
        {
            vel.y = jumpSpeed;
            justJumped = true;
        }

        if (jumpInput == false)
        {
            justJumped = false;
        }
        rb.velocity = vel;
    }

    public void Kill()
    {
        //Do kill thing
        Debug.Log("Death");
    }

}
