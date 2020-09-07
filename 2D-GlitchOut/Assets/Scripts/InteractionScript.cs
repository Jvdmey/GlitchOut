using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScript : MonoBehaviour
{
    bool colliderCheck;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            colliderCheck = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            colliderCheck = false;
        }
    }

    private void Update()
    {
        if (colliderCheck == true && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }
}
