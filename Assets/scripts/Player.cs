using NUnit.Framework;
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
    public int extraJumpsValue = 1;
    private int extrajumps;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        extrajumps = extraJumpsValue;
    }

    void Update()
    {
        float moveinput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveinput * movespeed, rb.linearVelocity.y);

        if (isgrounded)
        {
            extrajumps = extraJumpsValue;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isgrounded)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
            }
            else if (extrajumps > 0)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
                extrajumps--;
            }
        }
    }

    private void FixedUpdate()
    {
        isgrounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, GroundLayer);
    }
}
