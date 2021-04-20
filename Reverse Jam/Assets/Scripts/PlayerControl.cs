using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    PlayerReset playerReset;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public bool grounded = false;
    // Start is called before the first frame update
    void Start()
    {
        playerReset = GetComponent<PlayerReset>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerReset.isLocalRewinding){
        
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * moveSpeed;
            if(Input.GetButtonDown("Jump") && grounded)
            {
                Jump();
            }
        }
    }

    void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }
}
