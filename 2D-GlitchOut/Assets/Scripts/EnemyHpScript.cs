using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpScript : MonoBehaviour
{

    public float hitPoints = 100;

    public GameObject hpBar;

    void Update()
    {
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.collider.tag == "Player")
        {
            hitPoints -= 25;
            hpBar.transform.localScale = new Vector3(hitPoints / 100, hpBar.transform.localScale.y, hpBar.transform.localScale.z);
        }


    }
}
