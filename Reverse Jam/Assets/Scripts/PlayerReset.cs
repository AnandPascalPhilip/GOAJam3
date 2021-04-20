using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    public bool isLocalRewinding = false;
    List<Vector3> positions;
    void Start()
    {
        positions=new List<Vector3>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Backspace))
            StartRewind();
        if (Input.GetKeyUp(KeyCode.Backspace))
            StopRewind();
    }
    void FixedUpdate(){
        if (isLocalRewinding == true)
            Rewind();
        else
            Record();
    }

    void Rewind(){
        Debug.Log("Movingback");
        transform.position = positions[0];
        positions.RemoveAt(0);
    }
    void Record(){
        positions.Insert(0,transform.position);
        Debug.Log("Logging");
    }
        public void StartRewind ()
    {
        isLocalRewinding = true;
        Debug.Log("Rewind");
    }
    public void StopRewind ()
    {
        isLocalRewinding = false;
        Debug.Log("Rewindstopped");
    }
}
