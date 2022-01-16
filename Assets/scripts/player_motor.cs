using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_motor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 5.0f;
    private float VerticalVelocity = 0.0f;
    private float gravity = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = Vector3.zero;
        if(controller.isGrounded)
        {
            VerticalVelocity = -0.5f;
        }
        else
        {
            VerticalVelocity -= gravity * Time.deltaTime;
        }

        // X is Left and Right
        moveVector.x = Input.GetAxis("Horizontal") * speed;

        // Y is Left and Right
        moveVector.y = VerticalVelocity;

        // Z is Left and Right
        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime);
    }
    public void SetSpeed(float modifier)
    {
        speed = 5.0f + modifier;
    }
 

}
