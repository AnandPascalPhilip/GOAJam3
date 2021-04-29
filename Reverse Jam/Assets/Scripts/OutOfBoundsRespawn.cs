using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsRespawn : MonoBehaviour
{
    //public Vector2 spawnPos;
    public GameObject respawn;

    // Start is called before the first frame update
    void Start()
    {
        //spawnPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 2.5f);
        respawn = GameObject.FindGameObjectWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            collision.gameObject.transform.position = respawn.transform.position;
            collision.gameObject.GetComponent<PlayerControl>().hasKey = false;
            Debug.Log("(respawn) hasKey = " + collision.gameObject.GetComponent<PlayerControl>().hasKey);
        }
    }
}
