using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    float playerSpeed = 5;
    float jumpForce = 5;

    bool onGround;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(h * playerSpeed, rb.velocity.y, v * playerSpeed);

        Ray rcast = new Ray(transform.position, Vector3.down);

        Debug.DrawLine(rcast.origin, rcast.origin + (Vector3.down * 10));

        RaycastHit hit;

        if (Physics.Raycast(rcast, out hit, 10))
        {
            if (hit.transform != null)
            {

                if (hit.transform.GetComponent<GroundScript>() != null)
                {
                    onGround = true;
                }
                else
                {
                    onGround = false;
                }
            }
        }

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

    }

    void Jump()
    {
        if (onGround)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }
}