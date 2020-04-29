using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    BoxCollider bc;
    public float speed = 0;
    private float sX, sY, sZ;
    private void Start()
    {
        speed = speed * rb.mass;
        randomSize();
    }
    void Update()
    {
        checkOutofScreen();
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, -speed * Time.deltaTime);
    }
    void checkOutofScreen()
    {
        if (rb.position.z < -5 || rb.position.y < -1)
        {
            Destroy(this.gameObject);
        }
    }
    void randomSize()
    {
        sX = Random.Range(0.5f, 3f);
        sY = Random.Range(0.5f, 3f);
        sZ = Random.Range(0.5f, 3f);
        this.transform.localScale = new Vector3(sX, sY, sZ);
    }
}
