using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponent : MonoBehaviour {

    public CharacterController2D controller;

    Rigidbody2D rb;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = -4.3f;
    }

    // Update is called once per frame
    void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            rb.gravityScale *= -1;
        }

	}

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        
        jump = false;
    }

}
