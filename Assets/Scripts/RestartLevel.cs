using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour
{
    public GameManager gameManager;
    public void resetLevel()
    {
        gameManager.EndGame();
    }
}
