﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBullet : MonoBehaviour
{
    
    public float speed = 15f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.right * speed;
    }
    
}
