using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSoundM : MonoBehaviour
{
    public AudioSource SoundEffect;

    public void OnCollisionEnter(Collision collision)
    {
        SoundEffect.Play();    
    }
}
