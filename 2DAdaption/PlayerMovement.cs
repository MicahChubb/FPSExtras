using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    // New Input controls
    private CharacterInput controls;

    // This sets up out controls as per usual V
    void Awake()
    {
        controls = new CharacterInput();
    }

    void OnEnable()
    {
        controls.Enable();
    }
    void OnDisable()
    {
        controls.Disable();
    }
    // End set up of our controls section   ^

    // Update is called once per frame
    void Update()
    {
        // The below works because they both effectivelie return a number between -1 and 1 and then multiply by run speed
        // Old line:
        // horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        // New line:
        horizontalMove = controls.Player.Move.ReadValue<float>() * runSpeed;

        // The below works because they both effectively return a boolean, a true/false value
        // Old line:
        // if(Input.GetButtonDown("Jump"))
        // New line:
        if (controls.Player.Jump.triggered)
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
