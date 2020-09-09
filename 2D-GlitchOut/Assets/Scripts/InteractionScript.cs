using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScript : MonoBehaviour
{
    bool colliderCheck;
    private InventorySystem inventory; //Imported From Ties
    public GameObject ItemButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>(); //Imported From Ties
    }

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
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(ItemButton, inventory.slots[i].transform); //Imported From Ties
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
