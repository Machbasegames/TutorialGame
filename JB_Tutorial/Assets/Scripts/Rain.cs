using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public int speed = 5;
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, -1, 0) * speed * Time.deltaTime;
    }
}
