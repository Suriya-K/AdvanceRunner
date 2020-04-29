using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 0;
    public float sidewardForce = 0;
    public float jumppingForce = 0;
    public bool isgoDown = false;
    private bool togglejump = false;
    private bool onGround = true;
    // using FixedUpdate cause we mess with Physics.
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (togglejump)
        {
            if (Input.GetKey("space"))
            {
                //Debug.Log("Can Jump");
                rb.AddForce(0, jumppingForce * Time.deltaTime, 0);
                togglejump = false;
            }
        }
        // Fall Detect
        if (!isgoDown)
        {
            if (rb.position.y <= 0)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }
        else
        {
            if (rb.position.y <= -69f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }

        /* if (rb.position.y <= -2f)
         {
             forwardForce = 1000;
         }
         */
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        increaseMass();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "isDownDetect")
        {
            Debug.Log(isgoDown);
            isgoDown = true;
        }
        if (collision.collider.tag == "Floor")
        {
            rb.mass = 10;
            togglejump = true;
            onGround = true;
            //Debug.Log(collision.collider.name);
        }
        if (collision.collider.tag == "Floor" && rb.velocity.z <= 0 && rb.position.y < 0)
        {
            Debug.Log("less");
            rb.AddForce(0, 0, -1000 * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Floor")
        {
            onGround = false;
        }
    }
    private void increaseMass()
    {
        if (!onGround)
        {
            //Debug.Log("add Mass");
            //Debug.Log(rb.mass);
            rb.mass += 25 * Time.deltaTime;

        }
    }
}
