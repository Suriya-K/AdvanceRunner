using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMoveMent : MonoBehaviour
{
    Transform tf;
    private void Start()
    {
        tf = this.GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -10f * Time.deltaTime);
    }
}
