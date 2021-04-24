using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    PlayerControl controller;
    public int grounds=0;
    public bool playerGrounded;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponentInParent<PlayerControl>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Terrain")
        {
            grounds++;
            controller.grounded = true;
        }
    }
        private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Terrain"){
        grounds--;
            if(grounds==0){   
                controller.grounded = false;
            }
        }
    }
}
