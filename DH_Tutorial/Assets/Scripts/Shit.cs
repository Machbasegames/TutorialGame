using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {

        switch(other.transform.tag)
        {
            case "Ground":
                GameObject.Destroy(gameObject, 1f);
                break;
            case "Player":
                GameObject.Destroy(gameObject, 0f);
                break;
        }
    }
}
