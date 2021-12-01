using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Zone : MonoBehaviour
{
    [SerializeField] Transform Points;
    [SerializeField] private GameObject PlayZone;
    
    void OnTriggerEnter(Collider zone)
    {
        if (zone.tag == "Player")
        {
            StartCoroutine(StartPlatform());
           
            //StartCoroutine("off");
            
        }
    }

    IEnumerator off()
    {
       yield return new WaitForSeconds(20f);
       Destroy(this);
       
    }
    
    IEnumerator StartPlatform()
    {
        yield return new WaitForSecondsRealtime(2.8f);
        Instantiate(PlayZone, Points.position, Quaternion.identity);
    }
    
}
