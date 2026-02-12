using UnityEngine;

public class Player : MonoBehaviour
{
    public float movespeed = 5f;
    public float jumpforce = 10f;
    public Transform groundcheck;
    public float groundcheckradius = 0.2f;
    public LayerMask GroundLayer;
    private Rigidbody2D rb;
    private bool isgrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveinput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveinput * movespeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
        }
    }

    private void FixedUpdate()
    {
        isgrounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, GroundLayer);
    }
}
