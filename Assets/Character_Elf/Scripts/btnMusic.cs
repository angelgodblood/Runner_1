using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnMusic : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip hover;
    [SerializeField] AudioClip click;
    public void HoverSound()
    {
        audioSource.PlayOneShot(hover);
    }

    public void ClickSound()
    {
        audioSource.PlayOneShot(click);
    }
}
