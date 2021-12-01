using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_bus : MonoBehaviour
{
    public float timescale = 0;
    void Start()
    { 
        StartCoroutine(Runtime());
    }

IEnumerator Runtime()
{
    Time.timeScale = 0;
    yield return new WaitForSeconds(0.02f);
    timescale++;
    Destroy(gameObject);
}
}
