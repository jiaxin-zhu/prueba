using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZ_PlayerMovement : MonoBehaviour
{
    //Player variables
    public CharacterController controller;
    public float speed = 12f;

    //Gravity variables
    public float gravity = -9.81f;

    //Ground check variables
    public float groundDistance = 0f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
