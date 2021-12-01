using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Level : MonoBehaviour
{
    public GameObject FP;
    
    void Start()
    {
        FP.SetActive(true);
        {
            Time.timeScale = 0;
        }

    }
}

