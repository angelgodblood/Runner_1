using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityTCV1 : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    void Start()
    {
        StartCoroutine(SpeedFast());//с течением времени,меняется скорость
        StartCoroutine("StopSpeed4");
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * -speed * Time.deltaTime);
        StartCoroutine(Moving());
     
    }

    IEnumerator Moving()
    {
        yield return new WaitForSecondsRealtime(4f);
        
    }
    IEnumerator StopSpeed4()
    {
        yield return new WaitForSecondsRealtime(25f);
        Destroy(gameObject);
    }

    IEnumerator SpeedFast()
    {
        while (speed < maxSpeed)
        {
            yield return new WaitForSecondsRealtime(1f);
            speed += 1;

        }

    }
}