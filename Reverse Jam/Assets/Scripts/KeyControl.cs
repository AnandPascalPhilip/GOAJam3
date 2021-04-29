using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControl : MonoBehaviour
{
    GameObject player;
    public GameObject key;
    public GameObject keyUI;
    public bool hasKey;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        hasKey = false;
        Debug.Log("key = " + key);
        Debug.Log("keyUI = " + keyUI);
    }

    // Update is called once per frame
    void Update()
    {
        hasKey = player.GetComponent<PlayerControl>().hasKey;
        if(!hasKey && !key.activeInHierarchy)
        {
            key.SetActive(true);
        }
        if(key.activeInHierarchy)
        {
            keyUI.SetActive(false);
        }
        else
        {
            keyUI.SetActive(true);
        }
    }
}
