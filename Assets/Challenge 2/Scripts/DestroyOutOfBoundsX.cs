﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -43f;
    private float bottomLimit = -5f;


    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 

        // Destroy balls if y position is less than bottomLimit
        if (transform.position.y < bottomLimit)
        {
           Destroy(gameObject);
        }

        if (transform.position.y < 0)
        {
            // If the ball hits the ground, a “Game Over” debug message is displayed
            Debug.Log("Game Over");
        }

    }
   
}
