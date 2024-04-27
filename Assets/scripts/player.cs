using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    public static Transform Instance { get; }

    
    private Vector2 movement;
    private Rigidbody2D rb;
    private bool facingRight = true;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = new Vector2(
                    (Input.GetKey(KeyCode.A) ? -1 : 0) + (Input.GetKey(KeyCode.D) ? 1 : 0),
                    (Input.GetKey(KeyCode.S) ? -1 : 0) + (Input.GetKey(KeyCode.W) ? 1 : 0));
        
        if (facingRight && movement.x > 1e-8 || !facingRight && movement.x < -1e-8)
            Flip();
    }

    private void Flip()
    {
        facingRight = !facingRight;
        var scalar = transform.localScale;
        scalar.x *= -1;
        transform.localScale = scalar;
    }
    private void FixedUpdate()
    {
        rb.velocity = movement.normalized * moveSpeed;
    }
}
