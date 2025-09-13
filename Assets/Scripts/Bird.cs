using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("References")]
    Rigidbody2D rb;

    [Header("Settings")]
    [SerializeField] float jumpForce;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }
}
