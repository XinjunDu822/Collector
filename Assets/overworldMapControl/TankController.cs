using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TankMovement : MonoBehaviour
{
    [SerializeField] private AudioSource tankMoveSound;
    [SerializeField] private AudioSource tankRotateSound;
    [SerializeField] private AudioSource ambient;
    public float moveSpeed = 5f;
    public float rotateSpeed = 150f;
    private float timer = 0.1f;
    private float soundtimer = 1f;
    private float rotatetimer = 0.1f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        ambient.Play();
    }

    void FixedUpdate()
    {
        float moveInput = Input.GetAxisRaw("Vertical");
        float rotateInput = Input.GetAxisRaw("Horizontal");

        float rotation = -rotateInput * rotateSpeed * Time.fixedDeltaTime;


        rb.MoveRotation(rb.rotation + rotation);

        Vector2 forward = transform.up * moveInput * moveSpeed * Time.fixedDeltaTime;

        bool isMoving = forward.magnitude > 0f;
        bool isRotating = rotateInput != 0f;

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

        if (isRotating && !tankRotateSound.isPlaying)
        {
            Debug.Log("rotate playing");
            tankRotateSound.Play();


        }
        else if (!isRotating && tankRotateSound.isPlaying)
        {
            rotatetimer -= Time.deltaTime;
            if (rotatetimer <= 0)
            {
                tankRotateSound.Stop();
                rotatetimer = 0.1f;
            }

        }
        if (isMoving)
        {
            soundtimer -= Time.deltaTime;
            if (soundtimer <= 0)
            {
                StartCoroutine(Camera.main.GetComponent<ScreenShake2D>().Shake(0.2f, 0.15f));
                soundtimer = 1.55f;
            }
        }

        rb.MovePosition(rb.position + forward);
    }
}
