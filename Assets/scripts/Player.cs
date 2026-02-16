using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float movespeed = 5f;
    public int coins;
    public int health = 100;
    public float jumpforce = 10f;
    public Transform groundcheck;
    public float groundcheckradius = 0.2f;
    public LayerMask GroundLayer;
    private Rigidbody2D rb;
    private bool isgrounded;
    public int extraJumpsValue = 1;
    private int extrajumps;
    private SpriteRenderer spriteRenderer;
    public Image healthImage;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        extrajumps = extraJumpsValue;
        spriteRenderer = GetComponent<SpriteRenderer>();
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

            healthImage.fillAmount = health / 100f;
        }
    }

    private void FixedUpdate()
    {
        isgrounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, GroundLayer);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            health -= 10;
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
            StartCoroutine(BlinkRed());

            healthImage.fillAmount = health / 100f;
            if (health <= 0)
            {
                Die();
            }
        }
    }
    private IEnumerator BlinkRed()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;
    }

    private void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }
}
