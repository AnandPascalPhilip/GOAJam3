using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallReset : MonoBehaviour {
    public bool isGlobalRewinding = false;
    Rigidbody2D rb;

    List<Vector3> positions;
    List<Quaternion> rotations;

    void Start() {
        positions = new List<Vector3>();
        rotations = new List<Quaternion>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Return))
            StartRewind();
        if (Input.GetKeyUp(KeyCode.Return))
            StopRewind();
    }

    void FixedUpdate ()
    {
        if (isGlobalRewinding == true)
            Rewind();
        else
            Record();
    }

    void Rewind ()
    {
    //    Debug.Log("Movingback");
        transform.position = positions[0];
        transform.rotation = rotations[0];
        positions.RemoveAt(0);
        rotations.RemoveAt(0);
    }

    void Record ()
    {
        positions.Insert(0,transform.position);
        rotations.Insert(0, transform.rotation);
        if (positions[0]==positions[1]&&rotations[0]==rotations[1]){
            positions.RemoveAt(0);
            rotations.RemoveAt(0);
        }
    //    Debug.Log("Logging");
    }

    public void StartRewind ()
    {
        isGlobalRewinding = true;
    //    Debug.Log("Rewind");
    }

    public void StopRewind ()
    {
        
        isGlobalRewinding = false;
        rb.simulated=false;
        rb.isKinematic=true;
        rb.simulated=true;
        rb.isKinematic=false;
    //    Debug.Log("Rewindstopped");
    }
}
