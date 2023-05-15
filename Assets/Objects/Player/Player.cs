using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed,JumpPower;
    Rigidbody rb;
    bool touchGround;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    void Move()//Player‚Ì“®‚­ˆ—
    {
        float x = Input.GetAxis("Horizontal") * Speed;
        float z = Input.GetAxis("Vertical") * Speed;
        Vector3 moveVector = new Vector3(x,0,z);
        rb.velocity = moveVector * Time.fixedDeltaTime;
    }

    void Jump()
    {
        if(!touchGround) return;
        rb.
    }
}
