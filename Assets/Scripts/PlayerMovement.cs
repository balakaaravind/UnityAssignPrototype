using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    private Vector3 rotationVal;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(5f, 0, 0);
        }else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(-5f, 0, 0);
        }else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(0, 0, 5f);
        }else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(0, 0, -5f);
        }
        //float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        //float zInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        ////transform.Translate(xInput, 0, zInput);
        //transform.Rotate()
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        
    }
}
