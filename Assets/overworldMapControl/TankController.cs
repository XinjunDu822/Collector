using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TankMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 150f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveInput = Input.GetAxisRaw("Vertical");
        float rotateInput = Input.GetAxisRaw("Horizontal");

        float rotation = -rotateInput * rotateSpeed * Time.fixedDeltaTime;
        rb.MoveRotation(rb.rotation + rotation);

        Vector2 forward = transform.up * moveInput * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forward);
    }
}
