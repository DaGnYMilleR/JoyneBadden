using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    public static Transform Instance { get; }

    private Animator animator;

    private Vector2 movement;
    private Rigidbody2D rb;
    private bool facingRight = true;
    
    public bool hasKey;
    public bool wordlySolved;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = new Vector2(
                    (Input.GetKey(KeyCode.A) ? -1 : 0) + (Input.GetKey(KeyCode.D) ? 1 : 0),
                    (Input.GetKey(KeyCode.S) ? -1 : 0) + (Input.GetKey(KeyCode.W) ? 1 : 0));
        
        animator.SetBool("isRunning", !movement.Equals(Vector2.zero));

        
        if (facingRight && movement.x > 1e-8 || !facingRight && movement.x < -1e-8)
            Flip();
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        gameObject.GetComponent<Rigidbody2D>().WakeUp();
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
        if (rb.velocity.x > 0)
            Debug.Log(rb.velocity.x);
    }
}
