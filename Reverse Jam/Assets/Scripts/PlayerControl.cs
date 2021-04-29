using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    PlayerReset playerReset;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public bool grounded = false;
    public bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {
        playerReset = GetComponent<PlayerReset>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerReset.isLocalRewinding){
            rb.simulated = true;
            rb.gravityScale = 1;
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * moveSpeed;
            if(Input.GetButtonDown("Jump") && grounded)
            {
                Jump();
            }
        } else {
            rb.simulated = false;
            rb.gravityScale = 0;
        }
    }

    void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }
}
