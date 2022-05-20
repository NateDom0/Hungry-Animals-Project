using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsM : MonoBehaviour
{
    private float topBound = 30; //not using '30.0f'?
    private float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); // lowercase gameObject - refers to current game object that the script is applied to
        } 
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over"); //prompts 'game over' in console
            Destroy(gameObject);
        }
    }
}