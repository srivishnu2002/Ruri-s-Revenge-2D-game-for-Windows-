using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public Joystick joystick;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
   

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        //if(joystick.Horizontal >= .2f)
        //{
        //  horizontalMove = runSpeed;
        //}
        //else if (joystick.Horizontal <= -.2f)
        //{
        //   horizontalMove = -runSpeed;
        //}
        //else
        //{
        //    horizontalMove = 0f;
        //}

        float verticalMove = joystick.Vertical;

        

        if (verticalMove >= .5f)
        {
            jump = true;
            animator.SetBool("IsJumping", true);
            
            
                
        }

        //if (verticalMove <= -.5f)
        //{
        //    crouch = true;
        //}
        //else 
        //{
        //    crouch = false;
        //}
    }
    

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }
    

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}


