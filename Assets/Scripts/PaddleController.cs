using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public Rigidbody2D rb;

    private Vector2 moveInput;

    public float moveSpeed;

    private void Update()
    {
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // print($"{Input.GetAxis("Vertical")} {Input.GetAxisRaw("Vertical")}");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0f, moveInput.y) * moveSpeed;
    }
}
