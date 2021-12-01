using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityTownV1 : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        StartCoroutine("StopSpeed3");
    }

    void Update()
    {
        transform.Translate(Vector3.forward * -speed * Time.deltaTime);
    }
    IEnumerator StopSpeed3()
    {
        yield return new WaitForSeconds(8f);
        Destroy(gameObject);
    }
    }
