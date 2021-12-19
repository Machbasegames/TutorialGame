using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpPower = 300f;

    Vector3 moveVelocity;
    Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = transform.GetComponent<Rigidbody2D>();

        moveVelocity = Vector3.zero;

        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        moveVelocity.Set(Input.GetAxis("Horizontal"),
                         0f,
                         0f);
        moveVelocity = moveVelocity * Time.deltaTime * moveSpeed;

        transform.Translate(moveVelocity);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rigidBody.velocity = Vector2.zero;
        rigidBody.AddForce(Vector2.up * jumpPower);
    }
}
