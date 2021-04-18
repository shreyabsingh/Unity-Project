using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float moveForce = 1000F;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a forward force
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(moveForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, moveForce * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-moveForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -moveForce * Time.deltaTime);
        }

        if (Input.GetKey("space"))
        {
            rb.AddForce(0, moveForce * Time.deltaTime, 0);
        }
    }
}
