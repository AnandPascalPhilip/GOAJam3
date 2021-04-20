using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    GameObject Player;
    public int grounds=0;
    public bool playerGrounded;

    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Terrain")
        {
            grounds++;
            Player.GetComponent<PlayerControl>().grounded = true;
        }
    }
        private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Terrain"){
        grounds--;
            if(grounds==0){   
                Player.GetComponent<PlayerControl>().grounded = false;
            }
        }
    }
}
