using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float moveSpeed = 10f;

    Vector3 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        moveVelocity = Vector3.zero;

        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        moveVelocity.Set(Input.GetAxis("Horizontal"),
                         Input.GetAxis("Vertical"),
                         0f);
        moveVelocity = moveVelocity * Time.deltaTime * moveSpeed;

        Debug.Log(moveVelocity);

        transform.Translate(moveVelocity);
    }
}
