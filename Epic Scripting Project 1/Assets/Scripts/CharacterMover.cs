﻿using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{

    public CharacterController controller;
    private Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpForce = 10f;
    private int jumpCount = 0;
    public int jumpCountMax = 2;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    { 
        if(controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }

        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        if(Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpForce;
            jumpCount++;
        }

       
        positionDirection.y -= gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }
}
