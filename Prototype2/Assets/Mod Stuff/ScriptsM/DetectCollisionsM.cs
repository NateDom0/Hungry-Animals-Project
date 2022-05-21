using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsM : MonoBehaviour
{
    // override a function that already exists in the MonoBehaviour class
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject); //System knows "other" game object?
    }

}
