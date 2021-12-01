using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameLevel : MonoBehaviour
{
    public GameObject TextLvl;
    public GameObject T3;
    public GameObject T2;
    public GameObject T1;
    public GameObject start;
    public bool Run = false;
    
    void Start()
    {
      
      StartCoroutine("off");
        TextLvl.SetActive(true);

      StartCoroutine("T3T");
        T3.SetActive(true);
     
    }
    
   IEnumerator off()
   {
     
     yield return new WaitForSeconds(4f);
     TextLvl.SetActive(false);
   }

   IEnumerator T3T()
   {

     yield return new WaitForSeconds(0.5f);
     T3.SetActive(false);
     yield return new WaitForSeconds(0.5f);
     T2.SetActive(true);
     yield return new WaitForSeconds(0.5f);
     T2.SetActive(false);
     yield return new WaitForSeconds(0.5f);
     T1.SetActive(true);
     yield return new WaitForSeconds(0.5f);
     T1.SetActive(false);
     yield return new WaitForSeconds(0.5f);
     start.SetActive(true);
     yield return new WaitForSeconds(0.7f);
     yield return new WaitForSeconds(0.7f);
     start.SetActive(false);
     Run = true;
   }
   
}

