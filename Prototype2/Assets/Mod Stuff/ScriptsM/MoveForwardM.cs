using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Use this script to allow pizza to move forward

public class MoveForwardM : MonoBehaviour
{
    public float speed = 40.0f; //keep public in order to change speeds for animals and pizza

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
