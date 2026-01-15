using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Animator animator;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Get horizontal input only
        moveInput = Input.GetAxisRaw("Horizontal");

        // Update animator
        animator.SetFloat("Horizontal", moveInput);
        animator.SetFloat("Speed", Mathf.Abs(moveInput));

        // Flip sprite
        if (moveInput != 0)
            transform.localScale = new Vector3(Mathf.Sign(moveInput), 1, 1);
    }

    void FixedUpdate()
    {
        // Move horizontally only, keep current vertical velocity
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}
