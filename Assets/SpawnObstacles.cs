using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    private bool stopFunction = false;
    private int xPos = 0;
    public float zPos = 0;
    void Start()
    {

    }
    private void Update()
    {
        gameisStart();
    }
    private void gameisStart()
    {
        if (!stopFunction)
        {
            if (SceneManager.GetActiveScene().name == "lv03")
            {
                Debug.Log(GameManager.isStart);
                //Debug.Log("inhere");
                if (GameManager.isStart)
                {
                    StartCoroutine(spawnObstacles());
                    stopFunction = true;
                }
            }
        }

    }

    IEnumerator spawnObstacles()
    {
        while (true)
        {
            xPos = Random.Range(-5, 5);
            GameObject a = Instantiate(obstacle, new Vector3(xPos, 4, zPos), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
