using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallReset : MonoBehaviour {

    public bool isRewinding = false;

    List<Vector3> positions;

    void Start() {
        positions = new List<Vector3>();

    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Return))
            StartRewind();
        if (Input.GetKeyUp(KeyCode.Return))
            StopRewind();
    }

    void FixedUpdate ()
    {
        if (isRewinding == true)
            Rewind();
        else
            Record();
    }

    void Rewind ()
    {
        Debug.Log("Movingback");
        transform.position = positions[0];
        positions.RemoveAt(0);
    }

    void Record ()
    {
        positions.Insert(0,transform.position);
        Debug.Log("Logging");
    }

    public void StartRewind ()
    {
        isRewinding = true;
        Debug.Log("Rewind");
    }

    public void StopRewind ()
    {
        isRewinding = false;
        Debug.Log("Rewindstopped");
    }


}
