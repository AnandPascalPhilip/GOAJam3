using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUI : MonoBehaviour
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
        /*if(player.GetComponent<PlayerControl>().hasKey) //player hasKey
        {
            Debug.Log("player has key");
            if(!gameObject.activeInHierarchy) //player hasKey but keyUI inactive
            {
                gameObject.SetActive(true);
            }
        }
        else if (gameObject.activeInHierarchy) //player !hasKey but keyUI active
        {
            gameObject.SetActive(false);
        }*/
    }
}
