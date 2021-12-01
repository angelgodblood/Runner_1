using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieMusic : MonoBehaviour
{ 
  AudioSource die;
   
void Start()
{
 die = GetComponent<AudioSource>();
 die.Play();
}


}