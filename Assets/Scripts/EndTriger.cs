﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Yay");
        gameManager.completeLevel();
    }
}
