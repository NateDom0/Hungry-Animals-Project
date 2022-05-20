using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -45; // X-axis
    private float bottomLimit = -1; // Y-axis (affects balls)

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        // (see bottom comment)
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit) //z to 'y'
        {
            //Debug.Log("Game Over");
            Destroy(gameObject);
        }

    }
}

// if x < leftLimit, destroy object (i.e. x=-46)
// x is going towards the left(negative) limit