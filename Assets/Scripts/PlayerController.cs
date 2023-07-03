

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
public float moveSpeed = 5f;
 private Rigidbody rb;
    private Vector3 movement;
    Animator animator;




    private void Awake()

    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

    }



    private void Update()

    {

        // Read input axes

        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");



        // Calculate movement vector

        movement = new Vector3(moveHorizontal, 0f, moveVertical);

        movement.Normalize(); // Normalize to prevent faster diagonal movement




        // Rotate the player to face the movement direction (optional)

        if (movement != Vector3.zero)

        {

            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);

            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, 10f * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("isWalking", true);
        }



        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("isWalking", false);
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetBool("isWalking", true);
        }



        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("isWalking", true);
        }



        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("isWalking", true);
        }



        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("isWalking", false);
        }

    }



    private void FixedUpdate()

    {

        // Move the player

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}