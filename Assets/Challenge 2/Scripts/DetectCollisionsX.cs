using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // If the ball hits the ground, a “Game Over” debug message is displayed
        if (other.CompareTag("Ground"))
        {
            Debug.Log("Game Over");
        }

        Destroy(gameObject);
    }
}
