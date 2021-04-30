using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{

    public GameObject LevelCompleteScreen;

    void Start()
    {
        Debug.Log("clear screen = " + LevelCompleteScreen);
    }

    // Update is called once per frame
    public void CompleteLevel()
    {
        LevelCompleteScreen.SetActive(true);
        Debug.Log("LevelCompleteScreen: " + LevelCompleteScreen.activeInHierarchy);
    }
}
