using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform ball;

    public float moveSpeed;

    private void FixedUpdate()
    {
        float yDiff = ball.position.y - transform.position.y;
        if (Mathf.Abs(yDiff) < 0.3f) return;
        rb.velocity = new Vector2(0f, Mathf.Sign(yDiff) * moveSpeed);
        //Vector2 targetPosition = new Vector2(transform.position.x, ball.position.y);
        //if(Vector2.Distance(targetPosition, transform.position) > moveSpeed * Time.fixedDeltaTime)
        //{
        //    targetPosition = new Vector2(transform.position.x, Mathf.Sign(ball.position.y - transform.position.y) * moveSpeed + transform.position.y);
        //}
        //rb.MovePosition(targetPosition);
    }
}
