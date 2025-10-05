using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TankMovement : MonoBehaviour
{
    [SerializeField] private AudioSource tankMoveSound;
    public float moveSpeed = 5f;
    public float rotateSpeed = 150f;
    private float timer = 0.1f;

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

        bool isMoving = forward.magnitude > 0f;

        if (isMoving && !tankMoveSound.isPlaying)
        {
            Debug.Log("playing");
            tankMoveSound.Play();
        }
        else if (!isMoving && tankMoveSound.isPlaying)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                tankMoveSound.Stop();
                timer = 0.1f;
            }

        }

        rb.MovePosition(rb.position + forward);
    }
}
