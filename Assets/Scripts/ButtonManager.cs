using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Game is Exiting");
    }
}
