using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingForce;
    public float addedForce;

    private void Awake()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector3.zero;
        AddInitialForce();
    }

    private void AddInitialForce()
    {
        Vector2 direction = new Vector2(Mathf.Sign(Random.Range(-1f, 1f)), Mathf.Sign(Random.Range(-1f, 1f)));
        rb.AddForce(startingForce * direction, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            // Reset Position
            StartCoroutine(ResetPosition());
        }
        else if (collision.gameObject.CompareTag("Paddle"))
        {
            float speed = rb.velocity.magnitude;
            rb.velocity = rb.velocity.normalized * (speed + addedForce);
        }
    }

    // Coroutines
    private IEnumerator ResetPosition()
    {
        transform.position = Vector3.zero;
        rb.velocity = Vector2.zero;
        yield return new WaitForSeconds(2);
        AddInitialForce();
    }
}
