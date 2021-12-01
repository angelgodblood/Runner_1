using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop_brick_Music : MonoBehaviour
{
    AudioSource stop_brick;
    

void Start()
{
 stop_brick = GetComponent<AudioSource>();
 stop_brick.Play();

Destroy(gameObject,2);
}

}
