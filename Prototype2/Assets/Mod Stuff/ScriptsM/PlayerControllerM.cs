using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerM : MonoBehaviour
{
    //Variables
    public float horizontalInput;
    private float speed = 37.0f;
    private float xRange = 20.0f;

    public AudioSource fireSound; 

    public GameObject projectilePrefab; //instantiate new object called 'projectilePrefab' in update()

    // Update is called once per frame
    void Update()
    {
        //keep the player in bounds
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        } else if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal"); //get users left/right key input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space)) {
            
            fireSound.Play();

            // Launch a projectile from the player
            //Instantiate(projectilePrefab); -> launches pizza forward, but doesn't launch at player's position.
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            
        }

    }
}
