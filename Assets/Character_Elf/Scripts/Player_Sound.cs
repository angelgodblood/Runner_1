using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Sound : MonoBehaviour
{
    private AudioSource Move;
   

    void Start()
    {
        Move = GetComponent<AudioSource>();

    }

    void OnCollisionEnter(Collision other)
    {
        Move.Play();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "die")
        {
            Move.Play();
        }
    }

   
}
