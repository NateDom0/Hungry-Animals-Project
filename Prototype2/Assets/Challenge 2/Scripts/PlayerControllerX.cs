using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // use to control time b/w inputs
    private float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer <=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer += 1.5f; 
        }
    }
}
