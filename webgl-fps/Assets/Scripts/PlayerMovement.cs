using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    [SerializeField] private float speed = 12f;

    [SerializeField] private float gravity = -9.81f;

    private Vector3 velocity;


    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private LayerMask groundLayerMask;
    private bool isGrounded;

    [SerializeField] private float jumpHeight = 3f;


    // Update is called once per frame
    void Update()
    {
        GroundCheck();
        PlayerMove();
        Gravity();
        Jump();



    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(speed * Time.deltaTime * move);

    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
            {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
    }

    void GroundCheck()
    {
        if(IsGrounded() && velocity.y <0)
        {
            velocity.y = -2f;
        }
    }

    bool IsGrounded()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayerMask);
        return isGrounded;
    }

    void Gravity()
    {
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
