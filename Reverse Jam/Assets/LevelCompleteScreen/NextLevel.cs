using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void LoadNextLevel()
    {
        Debug.Log("loading level " + (SceneManager.GetActiveScene().buildIndex + 1));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
      Debug.Log("quit");
      Application.Quit();

    }

    public void Replay()
    {
        SceneManager.LoadScene("Level1");
    }

}
