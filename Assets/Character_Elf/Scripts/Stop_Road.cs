using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Road : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine("Run");
        
    }
    IEnumerator Run()
{
    Time.timeScale = 0.02f;
    yield return new WaitForSeconds(0.05f);
    Time.timeScale = 1f;
}
   
}
