using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movementSpeed = 2f;
    private float jumpForce=20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(movementSpeed*Time.deltaTime*Vector2.left,ForceMode2D.Impulse);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(movementSpeed*Time.deltaTime*Vector2.right,ForceMode2D.Impulse);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(movementSpeed*Time.deltaTime*Vector2.down,ForceMode2D.Impulse);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(movementSpeed*Time.deltaTime*Vector2.up,ForceMode2D.Impulse);
        }

       /* if (Input.GetButtonDown("Jump") && FindObjectOfType<grounded>().isGrounded)
        {
            Jump();
            FindObjectOfType<grounded>().isGrounded = false;
        }
        */
    }
    
    public void Jump()
    {
        rb.AddForce(jumpForce*Vector2.up,ForceMode2D.Impulse);
    }
}
