using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isDownTriger : MonoBehaviour
{
    public Movement player;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(player.isgoDown);
        player.isgoDown = true;
    }
}
