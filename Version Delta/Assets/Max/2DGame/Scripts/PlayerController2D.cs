using System.Diagnostics;
using UnityEngine;

    public class PlayerController2D : MonoBehaviour
    {
        bool faceRight = false;
        SpriteRenderer characterSprite;
        public float MovementSpeed = 3.0f;
        public float JumpSpeed = 4f;
        public float groundRadiusCheck = 0.3f;
        public LayerMask layers;

        Rigidbody2D rb;
        float moveInput;
        bool jumpInput = false;
        public bool onGround;

        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            characterSprite = GetComponentInChildren<SpriteRenderer>();
        }

        void Update()
        {
            moveInput = Input.GetAxis("Horizontal");
            jumpInput = Input.GetButton("Jump");

            if (moveInput < 0) // left
                faceRight = false;
            else if (moveInput > 0) // right
                faceRight = true;

            characterSprite.flipX = faceRight;
        }

        private void FixedUpdate()
        {
            Vector2 vel = rb.velocity;
            vel.x = moveInput * MovementSpeed;
            onGround = GroundCheck();

            if (jumpInput == true && onGround == true)
            {
                vel.y = JumpSpeed;
            
            }
            rb.velocity = vel;
        }

        bool GroundCheck()
        {
            Collider2D hitCollider = Physics2D.OverlapCircle(transform.position, groundRadiusCheck, layers);
            return hitCollider != null;
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, groundRadiusCheck);
        }
    }
