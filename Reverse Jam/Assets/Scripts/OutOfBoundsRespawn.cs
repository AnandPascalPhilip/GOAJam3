using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsRespawn : MonoBehaviour
{
    public Vector2 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == ("Respawn"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            gameObject.transform.position = spawnPos;
        }
    }
}
