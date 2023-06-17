using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playJump : MonoBehaviour
{
    
    private Rigidbody2D rb;
    public float jump;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }
}
