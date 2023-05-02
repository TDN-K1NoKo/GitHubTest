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

    private void Update()
    {
        Move();
    }

    void Move()//Player‚Ì“®‚­ˆ—
    {
        float x = Input.GetAxis("Horizontal") * Speed;
        float z = Input.GetAxis("Vertical") * Speed;
        Vector3 moveVector = new Vector3(x,0,z)* Time.fixedDeltaTime;
        rb.velocity = moveVector;
    }

    void Jump()
    {
        if(!touchGround) return;
        rb.
    }

    
}
