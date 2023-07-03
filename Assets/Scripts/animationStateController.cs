using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();

  
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("isWalking", true);
        }

       
        if (Input.GetKeyDown(KeyCode.T))
        {
            animator.SetBool("IsRunning", true);
        }
    }
}
