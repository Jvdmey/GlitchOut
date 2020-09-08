using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScript : MonoBehaviour
{
    bool colliderCheck;
    public PickUpAbility pickup;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            colliderCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            colliderCheck = false;
        }
    }

    private void Update()
    {
        if (colliderCheck == true && Input.GetKeyDown(KeyCode.E))
        {
            //pickup.GetComponent<PickUpAbility>().OnTriggerEnter2D(); //ERROR here
            Destroy(gameObject);
        }
    }
}
