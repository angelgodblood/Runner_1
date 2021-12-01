using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Music : MonoBehaviour
{
    private AudioSource gameover;
    void Start()
    {
        gameover = GetComponent<AudioSource>();
        gameover.Play();
    }

}
