using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        /*if(!player.GetComponent<PlayerControl>().hasKey)
        {
            if(!gameObject.activeInHierarchy)
            {
                gameObject.SetActive(true);
            }
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //key disappear
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerControl>().hasKey = true;
            Debug.Log("key got");
            gameObject.SetActive(false);
        }
    }
}
