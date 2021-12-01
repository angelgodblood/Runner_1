using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityTownClone : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;

    void Start()
    {
        StartCoroutine("StopSpeed2");
        StartCoroutine(SpeedFast());//с течением времени,меняется скорость
    }

    void Update()
    {
        transform.Translate(Vector3.forward * -speed * Time.deltaTime);
    }
    IEnumerator StopSpeed2()
    {
        yield return new WaitForSeconds(8f);
        Destroy(gameObject);
    }

    IEnumerator SpeedFast()
    {
        yield return new WaitForSeconds(5f);
        if (speed < maxSpeed)
        {
            speed += 10;
            StartCoroutine(SpeedFast());
        }
    }

}
