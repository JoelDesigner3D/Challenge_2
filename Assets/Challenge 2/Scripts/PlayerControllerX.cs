using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    Boolean pause = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Only allow the player to spawn a new dog after a certain amount of time has passed
            if (!pause) {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                StartCoroutine(ExampleCoroutine());
            }
            
            
        }
    }

    


IEnumerator ExampleCoroutine()
{
        pause = true;

        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(1);

        pause = false;
}

}
