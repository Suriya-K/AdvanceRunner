using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void controlGame()
    {
        SceneManager.LoadScene("Control");
    }
    public void returnToGame()
    {
        SceneManager.LoadScene("Menu");
    }
    public void exitGame()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }
}
