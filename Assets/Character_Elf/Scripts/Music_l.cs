using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_l : MonoBehaviour
{
    private AudioSource Level;
        void Awake()
    {
        Level = GetComponent<AudioSource>();
        Level.Play();
    }

}
