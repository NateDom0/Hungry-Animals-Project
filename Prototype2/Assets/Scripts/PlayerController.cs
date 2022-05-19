using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 15.0f;

    public GameObject projectilePrefab; //instantiate new object called 'projectilePrefab' in update()

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            
            // Launch a projectile from the player
            //Instantiate(projectilePrefab); -> launches pizza forward, but doesn't launch at player's position.
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            
        }

    }
}
