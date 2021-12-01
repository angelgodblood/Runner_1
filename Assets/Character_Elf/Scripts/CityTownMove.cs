using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityTownMove : MonoBehaviour
{
     
    public float speed;
    public float maxSpeed;

    private void Start()
    {
       
        StartCoroutine(FastMoving());
        //StartCoroutine(StopSpeed());
    }

    void Update()
    {
        //StartCoroutine(Moving());
        transform.Translate(Vector3.forward * -speed * Time.deltaTime);
    }

    IEnumerator Moving()
    {
        yield return new WaitForSecondsRealtime(4.0f);
        
    }

    IEnumerator FastMoving()
    {
        
        while (speed<maxSpeed)
        {
            yield return new WaitForSecondsRealtime(1f);
            speed += 2;
           
        }
    }

    IEnumerator StopSpeed()
    {
        yield return new WaitForSecondsRealtime(15f);
        Destroy(gameObject);
    }

}
