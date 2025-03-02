using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public Animator animator;

    public float runSpeed = 40f;

    float horizantalMove = 0f;
    bool jump = false;


    // Update is called once per frame
    void Update()
    {

        horizantalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizantalMove));

        if (Input.GetButtonDown("Jump"))
        {

            jump = true;
            animator.SetBool("IsJumping", true);

        }
      
    }

    public void OnLanding()
    {

        animator.SetBool("IsJumping", false);

    }

    void FixedUpdate()
    {


        controller.Move(horizantalMove * Time.fixedDeltaTime, false, jump);
        jump = false;   

    }

}
