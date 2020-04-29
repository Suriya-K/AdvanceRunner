using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement playerMovement;
    public static bool isPlayerHit = false;
    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Time.timeScale = 0.7f;
            playerMovement.enabled = false;
            isPlayerHit = true;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
