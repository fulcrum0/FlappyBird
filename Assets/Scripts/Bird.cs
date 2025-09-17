using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Bird : MonoBehaviour
{
    [Header("References")]
    Rigidbody2D rb;

    [Header("Settings")]
    [SerializeField] Manager gameManager;
    [SerializeField] float jumpForce;
    public bool isAlive;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        isAlive = true;
        Time.timeScale = 0;
    }

    void Update()
    {
        Jump();
    }

    void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) && isAlive)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

    void Die()
    {
        isAlive = false;
        Time.timeScale = 0;
        gameManager.playAgain.SetActive(true);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("GameOver"))
        {
            Die();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            gameManager.UpdateScore();
        }
    }
}
